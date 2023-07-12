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
	public partial class KartKhanStation: Form
	{
        public OleDbDataAdapter oda;
		public KartKhanStation()
		{
			InitializeComponent();
		     fillDGV1();
        }
        private void fillDGV1()
        {
            DateTime dtn = DateTime.Today.AddDays(1);
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            oda = new OleDbDataAdapter("SELECT station_info.* FROM station_info WHERE satation_id='"+tx_Stshn.Text+"'"
                +" and hour_stu<'"+dtn.ToString()+"' ORDER BY hour_stu DESC", con);
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dtSk;
            con.Close();
        }
        private void InsertStudent()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            OleDbDataAdapter od = new OleDbDataAdapter("select * from students", con);
            DataTable dtSlk = new DataTable();
            od.Fill(dtSlk);
            OleDbCommand commands = new OleDbCommand("INSERT INTO students " +
               "(stu_id,source, destination,hour_station)" +
               " VALUES (@a,@b,@c,@d)", con);
            commands.Parameters.Add("@a", OleDbType.WChar, 100, "stu_id");
            commands.Parameters.Add("@b", OleDbType.WChar, 100, "source");
            commands.Parameters.Add("@c", OleDbType.WChar, 100, "destination");
            commands.Parameters.Add("@d", OleDbType.DBTimeStamp, 8, "hour_station");
            od.InsertCommand = commands;
            DataRow dr0 = dtSlk.NewRow();
            dr0[0] = tx_Stu.Text;
            dr0[1] = tx_Stshn.Text;
            dr0[2] = tx_Destin.Text;
            dr0[3] = DateTime.Now.ToString();
            dtSlk.Rows.Add(dr0);
            od.Update(dtSlk);
            con.Close();
        }
        private void InsertStation()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=|DataDirectory|\\transport.sdf;");
            con.Open();
            DataTable dtSk = new DataTable();
            oda.Fill(dtSk);

            OleDbCommand command = new OleDbCommand("INSERT INTO station_info " +
                "(satation_id, stu_id, hour_stu, destination)" +
                " VALUES (@a,@b,@c,@d)", con);
            command.Parameters.Add("@a", OleDbType.WChar, 100, "satation_id");
            command.Parameters.Add("@b", OleDbType.WChar, 100, "stu_id");
            command.Parameters.Add("@c", OleDbType.DBTimeStamp, 8, "hour_stu");
            command.Parameters.Add("@d", OleDbType.WChar, 100, "destination");
            oda.InsertCommand = command;
            DataRow dr = dtSk.NewRow();
            dr[0] = tx_Stshn.Text;
            dr[1] = tx_Stu.Text;
            dr[2] = DateTime.Now.ToString();
            dr[3] = tx_Destin.Text;
            dtSk.Rows.Add(dr);
            oda.Update(dtSk);            
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertStation();
            InsertStudent();
            fillDGV1();
        }

        private void KartKhanStation_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void KartKhanStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillDGV1(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
	}
}
