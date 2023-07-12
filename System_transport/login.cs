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
    public partial class Form2 : Form
    {
        public string TypeLogOn;
        public Form2(string _TypeLogOn)
        {
            TypeLogOn = _TypeLogOn;
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string strConn = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; " +
           "Data Source=|DataDirectory|\\transport.sdf;";
            
            OleDbConnection con = new OleDbConnection(strConn);
            string query="select id, pass from server_info where id='"+txt_inputuser.Text+"' and pass='"+txt_inputpass.Text+"' and typ='"+TypeLogOn+"'";
            OleDbDataAdapter id_pass = new OleDbDataAdapter(query, con);//search user pass in table
            DataTable dt_idpass = new DataTable();
            id_pass.Fill(dt_idpass);
            if (dt_idpass.Rows.Count == 0)
            {
                MessageBox.Show("USERNAME or PASSWORD is Incorrect");
                return;
            }

            switch (TypeLogOn)
            {
                case "student":
                    string quer = "select stu_id from students where stu_id='" + txt_inputuser.Text + "'";
                    OleDbDataAdapter id = new OleDbDataAdapter(quer, con);//search user pass in table
                    DataTable dt= new DataTable();
                    id.Fill(dt);
                    if (dt.Rows.Count == 0)
                    MessageBox.Show("wellcome to shahrood univercity's system transport");
                    students st = new students();
                    st.info(txt_inputuser.Text, txt_inputpass.Text);
                    st.Show();
                    break;
                case "driver":
                    drivers d = new drivers();
                    d.info(txt_inputuser.Text, txt_inputpass.Text);
                    d.Show();
                    break;

                case "admin":
                    centeral_organization co = new centeral_organization();
                    co.info(txt_inputuser.Text, txt_inputpass.Text);
                    co.Show();
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    
    }
}
