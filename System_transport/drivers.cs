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
    public partial class drivers : Form
    {
        public string pass, id;
        public drivers()
        {
            InitializeComponent();
        }

        private void drivers_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void information_Click(object sender, EventArgs e)
        {     }
        public void info(string ids, string passs)
        {
            pass = passs;
            id = ids;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Text = id;
            txt_pass.Text = pass;
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
          "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbDataAdapter oda = new OleDbDataAdapter("select name from driver_info where driver_info.bus_id="+id, con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            txt_name.Text = dr[0].ToString();
        
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
        private void drivers_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void message_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
"Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from drivers_sms where driver_id='" + id + "'", con);
            DataTable dt_abc = new DataTable();
            oda.Fill(dt_abc);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt_abc;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
            "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from drivers_sms where doc_no='" + txt_sms.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dt.Rows[0]["action_yes_no"] = "YES";
            string driverLine = dt.Rows[0]["sms_text"].ToString();
            OleDbCommand command = new OleDbCommand("UPDATE drivers_sms SET action_yes_no = 'YES' WHERE doc_no ='"+txt_sms.Text+"'", con);
            oda.UpdateCommand = command;
            oda.Update(dt);

            oda = new OleDbDataAdapter("select x_p,y_p from gps_points where path='" + driverLine + "' order by station_no", con);
            dt = new DataTable();
            oda.Fill(dt);
            string gpsnow = dt.Rows[0][0].ToString() + "*" + dt.Rows[0][1].ToString();

            oda = new OleDbDataAdapter("select * from driver_info where bus_id='"+id+"'",con);
            dt = new DataTable();
            oda.Fill(dt);
            dt.Rows[0]["line_no"] = driverLine;
            dt.Rows[0]["gps_now"]=gpsnow;
            dt.Rows[0]["pertial_station"] = "01";
            OleDbCommand command1 = new OleDbCommand("UPDATE driver_info SET line_no =N'"+driverLine+"', gps_now=N'"+gpsnow+"', pertial_station=N'01'  WHERE bus_id ='" + id + "'", con);
            oda.UpdateCommand = command1;
            oda.Update(dt);
            con.Close();
        }

    }
}
