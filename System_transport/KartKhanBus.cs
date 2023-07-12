using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace safeprojectname
{
    public partial class KartKhanBus : Form
    {
        public KartKhanBus()
        {
            InitializeComponent();
            fillDGV1();
        }
        private void fillDGV1()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM drivers WHERE bus_id='" + tx_driver.Text + "' ORDER BY stu_destination", con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSk;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            insert_driver();
            update_station();
            update_student_WaitBus();            
            fillDGV1();
        }
        private void update_station()
        {
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from station_info ", con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);

            OleDbCommand command = new OleDbCommand("DELETE From station_info " +
                "where satation_id='" + (selected[3].Split('='))[1] + "' and stu_id='" + tx_Stu.Text + "'", con);
            oda.DeleteCommand = command;
            foreach (DataRow dr in dtSk.Rows)
                if (dr[0].ToString() == (selected[3].Split('='))[1] && dr[1].ToString() == tx_Stu.Text)
                {
                    dr.Delete();
                    break;
                }
            oda.Update(dtSk);
            con.Close();
        }
        private void update_student_WaitBus()
        {
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from students where stu_id='" +
                tx_Stu.Text + "' and source='" +(selected[3].Split('='))[1] + "' and (hour_bus IS NULL)"
                +" and (hour_station<='"+DateTime.Now+"')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dt.Rows[0][4] = DateTime.Now.ToString();
                TimeSpan ts = ((DateTime)dt.Rows[0][4] - (DateTime)dt.Rows[0][3]);
                dt.Rows[0][5] =(int) ts.TotalSeconds;
                dt.Rows[0][8] = tx_driver.Text;

                OleDbCommand command = new OleDbCommand("UPDATE students SET hour_bus =@a , wait_time=@b , bus_id=@c where stu_id='" +
                    tx_Stu.Text + "' and source='" +(selected[3].Split('='))[1]+ "' and (hour_bus IS NULL)", con);
                command.Parameters.Add("@a", OleDbType.DBTimeStamp, 8, "hour_bus");
                command.Parameters.Add("@b", OleDbType.Integer, 4, "wait_time");
                command.Parameters.Add("@c", OleDbType.WChar, 100, "bus_id");
                oda.UpdateCommand = command;
                oda.Update(dt);
            }
            con.Close();
        }
        private void update_student_Path()
        {
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from students where "+
                " destination='" +(selected[3].Split('='))[1]+ "'" +
            " and (path_time IS NULL) and (hour_bus IS NOT NULL) and"+
            " bus_id='"+tx_driver.Text+"'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TimeSpan ts = DateTime.Now - (DateTime)dr[4];
                    dr[6] =(int) ts.TotalSeconds;
                    ts = DateTime.Now - (DateTime)dr[3];
                    dr[7] = (int)ts.TotalSeconds;
                }
                OleDbCommand command = new OleDbCommand("UPDATE students SET path_time =@a , total_time=@b where " +
                    " destination='" + (selected[3].Split('='))[1] + "' and (path_time IS NULL) and (hour_bus IS NOT NULL)", con);
                command.Parameters.Add("@a", OleDbType.Integer, 4, "path_time");
                command.Parameters.Add("@b", OleDbType.Integer,4, "total_time");
                oda.UpdateCommand = command;
                oda.Update(dt);
            }
            con.Close();
        }
        private void update_Driver()
        {
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from drivers where bus_id='" +
                tx_driver.Text + "' and stu_destination='"+(selected[3].Split('='))[1]+ "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                dr.Delete();

            OleDbCommand command = new OleDbCommand("DELETE From drivers " +
                "where bus_id='" + tx_driver.Text + "' and stu_destination='" + (selected[3].Split('='))[1] + "'", con);
            oda.DeleteCommand = command;
            oda.Update(dt);
            con.Close();
        }
        private void KartKhanBus_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Start();
            tx_Stu.Enabled = false;
            button1.Enabled = false;
        }
        private void tx_driver_TextChanged(object sender, EventArgs e)
        {
           OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from driver_info where bus_id='"+tx_driver.Text+"'",con);
            DataTable dt0 = new DataTable();
            oda.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                tx_Line.Text = dt0.Rows[0][2].ToString();
                //fill combo
                oda = new OleDbDataAdapter("SELECT gps_points.* FROM gps_points,driver_info WHERE gps_points.path=driver_info.line_no and driver_info.bus_id='" + tx_driver.Text + "' and station_no>=pertial_station ORDER BY gps_points.station_no", con);
                DataTable dtSk = new DataTable();
                oda.Fill(dtSk);
                comboBox1.Items.Clear();
                for (int i = 0; i < dtSk.Rows.Count;i++ )
                {
                    comboBox1.Items.Add("x=" + dtSk.Rows[i][0].ToString() + ";y=" + dtSk.Rows[i][1].ToString() + ";map position=" + dtSk.Rows[i][3].ToString() + ";Stop=" + dtSk.Rows[i][4].ToString());
                }
            }
            con.Close();
        }
        private void insert_driver()
        {
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter st=new OleDbDataAdapter("select * from station_info where stu_id='"+tx_Stu.Text+"'",con);
            DataTable dts=new DataTable();
            st.Fill(dts);
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from drivers", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            DataRow dr = dt.NewRow();
            dr[0] = tx_driver.Text;
            dr[1] = tx_Stu.Text;
            dr[2] = dts.Rows[0][3].ToString();
            dt.Rows.Add(dr);
            OleDbCommand command = new OleDbCommand("insert into drivers(bus_id,stu_id,stu_destination)  VALUES(@a,@b,@c)", con);
            command.Parameters.Add("@a", OleDbType.WChar, 100, "bus_id");
            command.Parameters.Add("@b", OleDbType.WChar, 100, "stu_id");
            command.Parameters.Add("@c", OleDbType.WChar, 100, "stu_destination");
            oda.InsertCommand = command;
            oda.Update(dt);
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_student_Path();
            update_Driver();
            string[] selected = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';');
            string gpsnow = (selected[0].Split('='))[1] + "*" + (selected[1].Split('='))[1];
            string pertialstation = (selected[2].Split('='))[1];
            string[] strStop = selected[selected.Length - 1].Split('=');
            if (strStop[1] != "-1")
            {
                tx_Stu.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                tx_Stu.Enabled = false;
            }
            for (int i = 0; i < comboBox1.SelectedIndex; i++)
                comboBox1.Items.RemoveAt(0);


            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
            "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from driver_info where bus_id='"+tx_driver.Text+"'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dt.Rows[0][3] = gpsnow;
            dt.Rows[0][4] = pertialstation;
            OleDbCommand command1 = new OleDbCommand("UPDATE driver_info SET gps_now=N'" + gpsnow + "', pertial_station=N'"+pertialstation+"'  WHERE bus_id ='" + tx_driver.Text + "'", con);
            oda.UpdateCommand = command1;
            oda.Update(dt);
            con.Close();
        }
        private void KartKhanBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fillDGV1();
        }
     
    }
}
