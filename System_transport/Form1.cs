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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from students", con);
            con.Open();
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            OleDbDataAdapter odb = new OleDbDataAdapter("select * from station_info", con);
            DataTable dt = new DataTable();
            odb.Fill(dt);

            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] strRow = sr.ReadLine().Split(new char[] { '*' });
                if (strRow.Length < 4)
                    continue;
                DataRow dr = dtSk.NewRow();
                DataRow drr = dt.NewRow();

                for (int j = 0; j < strRow.Length; j++)
                    dr[j] = strRow[j];

                drr[0] = dr[1].ToString();
                drr[1] = dr[0].ToString();
                drr[3] = dr[2].ToString();
                drr[2] = dr[3].ToString();
                Boolean flag = true;
                foreach (DataRow dr6 in dtSk.Rows)
                {
                    if (dr6[0].ToString() == dr[0].ToString() && dr6[1].ToString() == dr[1].ToString() &&
                        dr6[2].ToString() == dr[2].ToString() && dr6[3].ToString() == dr[3].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    dtSk.Rows.Add(dr);
                    dt.Rows.Add(drr);
                }
            }
            sr.Close();
            fs.Close();
            OleDbCommand command = new OleDbCommand("INSERT INTO students (stu_id,source,destination,hour_station) VALUES (@a,@b,@c,@d)", con);
            command.Parameters.Add("@a", OleDbType.WChar, 100, "stu_id");
            command.Parameters.Add("@b", OleDbType.WChar, 100, "source");
            command.Parameters.Add("@c", OleDbType.WChar, 100, "destination");
            command.Parameters.Add("@d", OleDbType.DBTimeStamp, 8, "hour_station");
            oda.InsertCommand = command;
            oda.Update(dtSk);

            OleDbCommand commands = new OleDbCommand("INSERT INTO station_info (satation_id,stu_id,hour_stu,destination) VALUES (@a,@b,@c,@d)", con);
            commands.Parameters.Add("@a", OleDbType.WChar, 100, "satation_id");
            commands.Parameters.Add("@b", OleDbType.WChar, 100, "stu_id");
            commands.Parameters.Add("@c", OleDbType.DBTimeStamp, 8, "hour_stu");
            commands.Parameters.Add("@d", OleDbType.WChar, 100, "destination");
            odb.InsertCommand = commands;
            odb.Update(dt);
            con.Close();
        }
        private void bt_stu_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2("student");
            fm.Show();
        }
        private void bt_drive_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2("driver");
            fm.Show();
        }
        private void bt_central_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2("admin");
            fm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            KartKhanBus krt = new KartKhanBus();
            krt.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KartKhanStation k = new KartKhanStation();
            k.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from students", con);
            con.Open();
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSk;
            con.Close();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}

