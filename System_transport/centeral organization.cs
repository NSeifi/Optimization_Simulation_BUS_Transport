using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace safeprojectname
{
    public partial class centeral_organization : Form
    {
        public Bitmap bmp0;
        public string pass, id;
        private string SQLstr;
        public centeral_organization()
        {
            InitializeComponent();
        }
        private void centeral_organization_Load(object sender, EventArgs e)
        {
            SQLstr = "SELECT station_info.* FROM station_info ORDER BY hour_stu DESC";
            bmp0 = new Bitmap(Image.FromFile("masirha.jpg"), pictureBox2.Size);
            pictureBox2.Image = bmp0;
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer2.Start();
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Start();
        }
        public void info(string ids, string passs)
        {
            pass = passs;
            id = ids;
        }
        private void bt_station_info_Click(object sender, EventArgs e)
        {
            SQLstr = "SELECT station_info.* FROM station_info ORDER BY hour_stu DESC";
        }
        private void bt_avg_wait_Click(object sender, EventArgs e)
        {
            SQLstr = "select avg(wait_time) AS Avarage_Time,stu_id from students " +
                "where (wait_time is not null) group by stu_id ";
                 }
        private void bt_best_driver_Click(object sender, EventArgs e)
        {
            SQLstr = "select count(bus_id) AS Count_transport,bus_id from students"
            + " group by bus_id having bus_id is not null order by Count_transport DESC ";
                }
        private void bt_minmax_wait_Click(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
          "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbDataAdapter max = new OleDbDataAdapter("SELECT MAX(wait_time) AS Expr1, stu_id from students" +
                " group by stu_id order by Expr1 DESC", con);
            DataTable dt_abc = new DataTable();
            max.Fill(dt_abc);
            MessageBox.Show("Maximum Wait is=" + dt_abc.Rows[0][0].ToString() + " for student with this ID " + dt_abc.Rows[0][1].ToString());
            OleDbDataAdapter min = new OleDbDataAdapter("SELECT MIN(wait_time) AS Expr2, stu_id from students" +
                            " group by stu_id order by Expr2", con);
            dt_abc = new DataTable();
            min.Fill(dt_abc);
            MessageBox.Show("Minimum Wait is=" + dt_abc.Rows[0][0].ToString() + " for student with this ID " + dt_abc.Rows[0][1].ToString());
        }
        private void bt_del_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from server_info where id='" +
                txt_user.Text + "' and pass='" + txt_pas_add_del.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                dr.Delete();

            OleDbCommand command = new OleDbCommand("DELETE From server_info " +
                "where id='" + txt_user.Text + "'", con);
            oda.DeleteCommand = command;
            oda.Update(dt);
            if (txt_typ.Text.Equals("driver"))
                oda = new OleDbDataAdapter("select * from driver_info where bus_id='"
                    +txt_user.Text+"'", con);
            dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow drr in dt.Rows)
                drr.Delete();

            command = new OleDbCommand("DELETE From driver_info " +
                "where bus_id='" + txt_user.Text + "'", con);
            oda.DeleteCommand = command;
            oda.Update(dt);
            con.Close();
            MessageBox.Show("USER " + txt_user.Text + " DELETE Successfuly");
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("select * from server_info", con);
            DataTable dtSlk = new DataTable();
            od.Fill(dtSlk);
            OleDbCommand commands = new OleDbCommand("INSERT INTO server_info " +
               "(id,pass,typ)" +
               " VALUES (@a,@b,@c)", con);
            commands.Parameters.Add("@a", OleDbType.WChar, 100, "id");
            commands.Parameters.Add("@b", OleDbType.WChar, 100, "pass");
            commands.Parameters.Add("@c", OleDbType.WChar, 100, "typ");
            od.InsertCommand = commands;
            DataRow dr0 = dtSlk.NewRow();
            dr0[0] = txt_user.Text;
            dr0[1] = txt_pas_add_del.Text;
            dr0[2] = txt_typ.Text;
            dtSlk.Rows.Add(dr0);
            od.Update(dtSlk);
            if (txt_typ.Text.Equals("driver"))
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from driver_info", con);
                DataTable dtSk = new DataTable();
                oda.Fill(dtSk);
                OleDbCommand drive = new OleDbCommand("INSERT INTO driver_info " +
                   "(bus_id,name,line_no,gps_now)" +
                   " VALUES (@a,@b,@c,@d)", con);
                drive.Parameters.Add("@a", OleDbType.WChar, 100, "bus_id");
                drive.Parameters.Add("@b", OleDbType.WChar, 100, "name");
                drive.Parameters.Add("@c", OleDbType.WChar, 100, "line_no");
                drive.Parameters.Add("@d", OleDbType.WChar, 100, "gps_now");

                oda.InsertCommand = drive;
                DataRow dr = dtSk.NewRow();
                dr[0] = txt_user.Text;
                dr[1] = txt_name.Text;
                dr[2] = "0";
                dr[3] = "295*292";
                dtSk.Rows.Add(dr);
                oda.Update(dtSk);
            }
            con.Close();
            MessageBox.Show("USER " + txt_user.Text + " ADD Successfuly");
        }
        private void bt_aply_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text != txt_confirm.Text)
            {
                MessageBox.Show("Not Matched New Password");
                return;
            }
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
      "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from server_info where id=" + id + " and pass=" + pass, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dt.Rows[0][1] = txt_newpass.Text;
            OleDbCommand command = new OleDbCommand("UPDATE server_info SET pass =@pass WHERE id = @id", con);
            command.Parameters.Add("@pass", OleDbType.WChar, 100, "pass");
            command.Parameters.Add("@id", OleDbType.WChar, 100, "id");
            oda.UpdateCommand = command;
            oda.Update(dt);
            con.Close();
            MessageBox.Show("Successfuly Changed Password");
        }
        private void fillDGV1()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter(SQLstr, con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSk;
            con.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fillDGV1();
            fillDGV2();
        }
        private void centeral_organization_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = bmp0;
            Bitmap btm = new Bitmap(pictureBox2.Image);
            Graphics g = Graphics.FromImage((Image)btm);
            string strConngps = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
          "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection congps = new OleDbConnection(strConngps);
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT driver_info.bus_id, driver_info.line_no, driver_info.gps_now, COUNT(drivers.stu_id) AS Expr1 " +
                                                         "FROM drivers RIGHT OUTER JOIN " +
                                                         " driver_info ON drivers.bus_id = driver_info.bus_id " +
                                                         " GROUP BY driver_info.bus_id, driver_info.line_no, driver_info.gps_now", congps);
            DataTable dtgps = new DataTable();
            oda.Fill(dtgps);
            foreach (DataRow dr in dtgps.Rows)
            {
                string[] strgps = dr[2].ToString().Split(new char[] { '*' });
                int x = int.Parse(strgps[0]), y = int.Parse(strgps[1]);
                g.DrawString(dr[0].ToString(), new System.Drawing.Font(new FontFamily("Arial"), 10f), Brushes.Black, x - 5, y - 15);
                g.DrawString(dr[3].ToString(), new System.Drawing.Font(new FontFamily("Arial"), 10f), Brushes.Black, x - 5, y - 30);
                g.FillPie(Brushes.Red, new Rectangle(x - 5, y - 5, 10, 10), 0, 360);
                if (dr[1].ToString() == "2" || dr[1].ToString() == "3" || dr[1].ToString() == "4")
                    g.FillPolygon(Brushes.Red, new Point[] { new Point(x, y - 5), new Point(x, y + 5), new Point(x + 15, y) });
                else if (dr[1].ToString() == "1" || dr[1].ToString() == "5" || dr[1].ToString() == "6")
                    g.FillPolygon(Brushes.Red, new Point[] { new Point(x, y - 5), new Point(x, y + 5), new Point(x - 15, y) });
            }
            pictureBox2.Image = null;
            pictureBox2.Image = (Image)btm;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("select * from drivers_sms", con);
            DataTable dtSlk = new DataTable();
            od.Fill(dtSlk);
            OleDbCommand commands = new OleDbCommand("INSERT INTO drivers_sms " +
               "(driver_id,sms_time,sms_text,action_yes_no,doc_no)" +
               " VALUES (@a,@b,@c,@d,@e)", con);
            commands.Parameters.Add("@a", OleDbType.WChar, 100, "driver_id");
            commands.Parameters.Add("@b", OleDbType.WChar, 100, "sms_time");
            commands.Parameters.Add("@c", OleDbType.WChar, 100, "sms_text");
            commands.Parameters.Add("@d", OleDbType.WChar, 100, "action_yes_no");
            commands.Parameters.Add("@e", OleDbType.WChar, 100, "doc_no");
            od.InsertCommand = commands;
            DataRow dr0 = dtSlk.NewRow();
            dr0["driver_id"] = tx_driver_id.Text;
            dr0["sms_time"] = DateTime.Now.ToString();
            dr0["sms_text"] = tx_sms.Text;
            dr0["action_yes_no"] = "NO";
            dr0["doc_no"] = tx_Docid.Text;
            dtSlk.Rows.Add(dr0);
            od.Update(dtSlk);
            con.Close();
        }
        private void fillDGV2()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM drivers_sms", con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dtSk;
            con.Close();
        }
    }
}
