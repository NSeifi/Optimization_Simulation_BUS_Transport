namespace safeprojectname
{
    partial class drivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drivers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_stu_info = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.information = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_sms = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_aply = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.information.SuspendLayout();
            this.message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_stu_info
            // 
            this.txt_stu_info.Location = new System.Drawing.Point(197, 12);
            this.txt_stu_info.MaxLength = 450000;
            this.txt_stu_info.Multiline = true;
            this.txt_stu_info.Name = "txt_stu_info";
            this.txt_stu_info.ReadOnly = true;
            this.txt_stu_info.Size = new System.Drawing.Size(349, 25);
            this.txt_stu_info.TabIndex = 2;
            this.txt_stu_info.Text = "کاربر گرامی خوش آمدید، تنها اطلاعات قابل تغییر برای شما رمز عبور است.";
            this.txt_stu_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.information);
            this.tabControl1.Controls.Add(this.message);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 288);
            this.tabControl1.TabIndex = 3;
            // 
            // information
            // 
            this.information.Controls.Add(this.label4);
            this.information.Controls.Add(this.label3);
            this.information.Controls.Add(this.label2);
            this.information.Controls.Add(this.label1);
            this.information.Controls.Add(this.button1);
            this.information.Controls.Add(this.txt_pass);
            this.information.Controls.Add(this.txt_name);
            this.information.Controls.Add(this.txt_username);
            this.information.Location = new System.Drawing.Point(4, 22);
            this.information.Name = "information";
            this.information.Padding = new System.Windows.Forms.Padding(3);
            this.information.Size = new System.Drawing.Size(547, 262);
            this.information.TabIndex = 0;
            this.information.Text = "information";
            this.information.UseVisualStyleBackColor = true;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(140, 40);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(290, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(6, 40);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 0;
            // 
            // message
            // 
            this.message.Controls.Add(this.label8);
            this.message.Controls.Add(this.button3);
            this.message.Controls.Add(this.txt_sms);
            this.message.Controls.Add(this.dataGridView1);
            this.message.Location = new System.Drawing.Point(4, 22);
            this.message.Name = "message";
            this.message.Padding = new System.Windows.Forms.Padding(3);
            this.message.Size = new System.Drawing.Size(547, 262);
            this.message.TabIndex = 1;
            this.message.Text = "message";
            this.message.UseVisualStyleBackColor = true;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "SMS doc number";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Run SMS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_sms
            // 
            this.txt_sms.Location = new System.Drawing.Point(150, 168);
            this.txt_sms.Name = "txt_sms";
            this.txt_sms.Size = new System.Drawing.Size(100, 20);
            this.txt_sms.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 124);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_confirm);
            this.tabPage1.Controls.Add(this.txt_oldpass);
            this.tabPage1.Controls.Add(this.txt_newpass);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bt_aply);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 262);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "change password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "confirm";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(207, 95);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(100, 20);
            this.txt_confirm.TabIndex = 5;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(207, 23);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Size = new System.Drawing.Size(100, 20);
            this.txt_oldpass.TabIndex = 4;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(207, 63);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(100, 20);
            this.txt_newpass.TabIndex = 3;
            this.txt_newpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Old password";
            // 
            // bt_aply
            // 
            this.bt_aply.Location = new System.Drawing.Point(412, 89);
            this.bt_aply.Name = "bt_aply";
            this.bt_aply.Size = new System.Drawing.Size(75, 23);
            this.bt_aply.TabIndex = 0;
            this.bt_aply.Text = "apply";
            this.bt_aply.UseVisualStyleBackColor = true;
            this.bt_aply.Click += new System.EventHandler(this.bt_aply_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 423);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_stu_info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "drivers";
            this.Text = "drivers";
            this.Load += new System.EventHandler(this.drivers_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.drivers_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            this.message.ResumeLayout(false);
            this.message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_stu_info;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage information;
        private System.Windows.Forms.TabPage message;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_aply;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_sms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}