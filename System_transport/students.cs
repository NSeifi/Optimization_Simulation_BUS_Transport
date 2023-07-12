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
    public partial class students : Form
    {
        public string id, pass,tim;
        public students()
        {
            InitializeComponent();
        }
        private void students_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            timer1.Enabled = true;
            timer1.Start();
        }
        public void info(string ids, string passs)
        {
            pass = passs;
            id = ids;
        }
        private void btn_applay_Click(object sender, EventArgs e)
        {
            if (txt_tab_stu_pass1.Text != txt_tab_stu_pass2.Text)
            {
                MessageBox.Show("Not Matched New Password");
                return;
            }
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
      "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from server_info where id='" + id + "' and pass='" + pass+"'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dt.Rows[0][1] = txt_tab_stu_pass2.Text;
            OleDbCommand command = new OleDbCommand("UPDATE server_info SET pass =@pass WHERE id = @id", con);
            command.Parameters.Add("@pass", OleDbType.WChar, 100, "pass");
            command.Parameters.Add("@id", OleDbType.WChar, 100, "id");
            oda.UpdateCommand = command;
            oda.Update(dt);
            con.Close();
            MessageBox.Show("Successfuly Changed Password");
        }
        private void bt_aply_sta_Click(object sender, EventArgs e)
        {
           //reserve
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
                 "Data Source=|DataDirectory|\\transport.sdf;";
            OleDbConnection con = new OleDbConnection(strConn);
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from students", con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            DataRow dr = dtSk.NewRow();
            dr[0] = id;
            dr[1] = txt_stu_source.Text;
            dr[2] = txt_stu_dest.Text;
            dr[3] = tim;
            dtSk.Rows.Add(dr);
            OleDbCommand command = new OleDbCommand("INSERT INTO students (stu_id,source,destination,hour_station) VALUES (@a,@b,@c,@d)", con);
            command.Parameters.Add("@a", OleDbType.WChar, 100, "stu_id");
            command.Parameters.Add("@b", OleDbType.WChar, 100, "source");
            command.Parameters.Add("@c", OleDbType.WChar, 100, "destination");
            command.Parameters.Add("@d", OleDbType.DBTimeStamp, 100, "hour_station");
            oda.InsertCommand = command;
            oda.Update(dtSk);
            oda= new OleDbDataAdapter("select * from station_info",con);
            dtSk = new DataTable();
            oda.Fill(dtSk);
            DataRow drr = dtSk.NewRow();
            drr[0] = txt_stu_source.Text;
            drr[1] = id;
            drr[2] = tim;
            drr[3] = txt_stu_dest.Text;
            dtSk.Rows.Add(drr);
            command = new OleDbCommand("INSERT INTO station_info (satation_id,stu_id,hour_stu,destination) VALUES (@a,@b,@c,@d)", con);
            command.Parameters.Add("@a", OleDbType.WChar, 100, "satation_id");
            command.Parameters.Add("@b", OleDbType.WChar, 100, "stu_id");
            command.Parameters.Add("@c", OleDbType.DBTimeStamp, 8, "hour_stu");
            command.Parameters.Add("@d", OleDbType.WChar, 100, "destination");
            oda.InsertCommand = command;
            oda.Update(dtSk);
            con.Close();
            MessageBox.Show("Successfuly add");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_stu_station_time.Text = dateTimePicker1.Value.ToString();
            tim = txt_stu_station_time.Text;
        }
        private void tabPage_replace_Click(object sender, EventArgs e)
        {        }
        private void tabPage_pass_Click(object sender, EventArgs e)
        {   }
    }
}
