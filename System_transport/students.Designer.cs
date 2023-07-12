namespace safeprojectname
{
    partial class students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(students));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage_replace = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_aply_sta = new System.Windows.Forms.Button();
            this.txt_stu_dest = new System.Windows.Forms.TextBox();
            this.txt_stu_source = new System.Windows.Forms.TextBox();
            this.tabPage_pass = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tab_stu_pass0 = new System.Windows.Forms.TextBox();
            this.txt_tab_stu_pass2 = new System.Windows.Forms.TextBox();
            this.txt_tab_stu_pass1 = new System.Windows.Forms.TextBox();
            this.btn_applay = new System.Windows.Forms.Button();
            this.tab_stu = new System.Windows.Forms.TabControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_stu_station_time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_replace.SuspendLayout();
            this.tabPage_pass.SuspendLayout();
            this.tab_stu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "کاربر گرامی خوش آمدید، تنها اطلاعات قابل تغییر برای شما رمز عبور است";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // tabPage_replace
            // 
            this.tabPage_replace.Controls.Add(this.dateTimePicker1);
            this.tabPage_replace.Controls.Add(this.label7);
            this.tabPage_replace.Controls.Add(this.label6);
            this.tabPage_replace.Controls.Add(this.label5);
            this.tabPage_replace.Controls.Add(this.bt_aply_sta);
            this.tabPage_replace.Controls.Add(this.txt_stu_station_time);
            this.tabPage_replace.Controls.Add(this.txt_stu_dest);
            this.tabPage_replace.Controls.Add(this.txt_stu_source);
            this.tabPage_replace.Location = new System.Drawing.Point(4, 22);
            this.tabPage_replace.Name = "tabPage_replace";
            this.tabPage_replace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_replace.Size = new System.Drawing.Size(698, 240);
            this.tabPage_replace.TabIndex = 1;
            this.tabPage_replace.Text = "reserve";
            this.tabPage_replace.UseVisualStyleBackColor = true;
            this.tabPage_replace.Click += new System.EventHandler(this.tabPage_replace_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "source";
            // 
            // bt_aply_sta
            // 
            this.bt_aply_sta.Location = new System.Drawing.Point(120, 135);
            this.bt_aply_sta.Name = "bt_aply_sta";
            this.bt_aply_sta.Size = new System.Drawing.Size(75, 23);
            this.bt_aply_sta.TabIndex = 6;
            this.bt_aply_sta.Text = "apply";
            this.bt_aply_sta.UseVisualStyleBackColor = true;
            this.bt_aply_sta.Click += new System.EventHandler(this.bt_aply_sta_Click);
            // 
            // txt_stu_dest
            // 
            this.txt_stu_dest.Location = new System.Drawing.Point(163, 56);
            this.txt_stu_dest.Name = "txt_stu_dest";
            this.txt_stu_dest.Size = new System.Drawing.Size(100, 20);
            this.txt_stu_dest.TabIndex = 3;
            // 
            // txt_stu_source
            // 
            this.txt_stu_source.Location = new System.Drawing.Point(163, 20);
            this.txt_stu_source.Name = "txt_stu_source";
            this.txt_stu_source.Size = new System.Drawing.Size(100, 20);
            this.txt_stu_source.TabIndex = 1;
            // 
            // tabPage_pass
            // 
            this.tabPage_pass.Controls.Add(this.label4);
            this.tabPage_pass.Controls.Add(this.label3);
            this.tabPage_pass.Controls.Add(this.label2);
            this.tabPage_pass.Controls.Add(this.txt_tab_stu_pass0);
            this.tabPage_pass.Controls.Add(this.txt_tab_stu_pass2);
            this.tabPage_pass.Controls.Add(this.txt_tab_stu_pass1);
            this.tabPage_pass.Controls.Add(this.btn_applay);
            this.tabPage_pass.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pass.Name = "tabPage_pass";
            this.tabPage_pass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_pass.Size = new System.Drawing.Size(698, 240);
            this.tabPage_pass.TabIndex = 0;
            this.tabPage_pass.Text = "information";
            this.tabPage_pass.UseVisualStyleBackColor = true;
            this.tabPage_pass.Click += new System.EventHandler(this.tabPage_pass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Certificate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old Password";
            // 
            // txt_tab_stu_pass0
            // 
            this.txt_tab_stu_pass0.Location = new System.Drawing.Point(149, 45);
            this.txt_tab_stu_pass0.Name = "txt_tab_stu_pass0";
            this.txt_tab_stu_pass0.PasswordChar = '*';
            this.txt_tab_stu_pass0.Size = new System.Drawing.Size(100, 20);
            this.txt_tab_stu_pass0.TabIndex = 3;
            // 
            // txt_tab_stu_pass2
            // 
            this.txt_tab_stu_pass2.Location = new System.Drawing.Point(149, 97);
            this.txt_tab_stu_pass2.Name = "txt_tab_stu_pass2";
            this.txt_tab_stu_pass2.PasswordChar = '*';
            this.txt_tab_stu_pass2.Size = new System.Drawing.Size(100, 20);
            this.txt_tab_stu_pass2.TabIndex = 1;
            // 
            // txt_tab_stu_pass1
            // 
            this.txt_tab_stu_pass1.Location = new System.Drawing.Point(149, 71);
            this.txt_tab_stu_pass1.Name = "txt_tab_stu_pass1";
            this.txt_tab_stu_pass1.PasswordChar = '*';
            this.txt_tab_stu_pass1.Size = new System.Drawing.Size(100, 20);
            this.txt_tab_stu_pass1.TabIndex = 0;
            // 
            // btn_applay
            // 
            this.btn_applay.Location = new System.Drawing.Point(59, 137);
            this.btn_applay.Name = "btn_applay";
            this.btn_applay.Size = new System.Drawing.Size(75, 23);
            this.btn_applay.TabIndex = 2;
            this.btn_applay.Text = "applay";
            this.btn_applay.UseVisualStyleBackColor = true;
            this.btn_applay.Click += new System.EventHandler(this.btn_applay_Click);
            // 
            // tab_stu
            // 
            this.tab_stu.Controls.Add(this.tabPage_pass);
            this.tab_stu.Controls.Add(this.tabPage_replace);
            this.tab_stu.Location = new System.Drawing.Point(150, 62);
            this.tab_stu.Name = "tab_stu";
            this.tab_stu.SelectedIndex = 0;
            this.tab_stu.Size = new System.Drawing.Size(706, 266);
            this.tab_stu.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_stu_station_time
            // 
            this.txt_stu_station_time.Enabled = false;
            this.txt_stu_station_time.Location = new System.Drawing.Point(163, 88);
            this.txt_stu_station_time.Name = "txt_stu_station_time";
            this.txt_stu_station_time.Size = new System.Drawing.Size(204, 20);
            this.txt_stu_station_time.TabIndex = 5;
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_stu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "students";
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_replace.ResumeLayout(false);
            this.tabPage_replace.PerformLayout();
            this.tabPage_pass.ResumeLayout(false);
            this.tabPage_pass.PerformLayout();
            this.tab_stu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage_replace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_aply_sta;
        private System.Windows.Forms.TextBox txt_stu_dest;
        private System.Windows.Forms.TextBox txt_stu_source;
        private System.Windows.Forms.TabPage tabPage_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tab_stu_pass0;
        private System.Windows.Forms.TextBox txt_tab_stu_pass2;
        private System.Windows.Forms.TextBox txt_tab_stu_pass1;
        private System.Windows.Forms.Button btn_applay;
        private System.Windows.Forms.TabControl tab_stu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_stu_station_time;
    }
}