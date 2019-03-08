namespace Rabbit.MQTools
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.cbx_Topic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsume = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txt_topic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpage_send = new System.Windows.Forms.TabPage();
            this.txt_sendcontent = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_consume = new System.Windows.Forms.TabPage();
            this.txt_consume = new System.Windows.Forms.TextBox();
            this.chb_guid = new System.Windows.Forms.CheckBox();
            this.chb_random = new System.Windows.Forms.CheckBox();
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.txt_random = new System.Windows.Forms.TextBox();
            this.lbl_t = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabpage_s = new System.Windows.Forms.TabPage();
            this.txt_param11 = new System.Windows.Forms.TextBox();
            this.chb_param1 = new System.Windows.Forms.CheckBox();
            this.txt_param111 = new System.Windows.Forms.TextBox();
            this.chb_param2 = new System.Windows.Forms.CheckBox();
            this.txt_param22 = new System.Windows.Forms.TextBox();
            this.txt_param222 = new System.Windows.Forms.TextBox();
            this.chb_param3 = new System.Windows.Forms.CheckBox();
            this.txt_param33 = new System.Windows.Forms.TextBox();
            this.txt_param333 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabpage_send.SuspendLayout();
            this.tabPage_consume.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpage_s.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Topic
            // 
            this.cbx_Topic.FormattingEnabled = true;
            this.cbx_Topic.Location = new System.Drawing.Point(90, 33);
            this.cbx_Topic.Name = "cbx_Topic";
            this.cbx_Topic.Size = new System.Drawing.Size(280, 20);
            this.cbx_Topic.TabIndex = 0;
            this.cbx_Topic.Text = "- 请选择 -";
            this.cbx_Topic.SelectedIndexChanged += new System.EventHandler(this.cbx_Topic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择Topic：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数设置ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Image = global::Rabbit.MQTools.Properties.Resources.icon_set;
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.参数设置ToolStripMenuItem.Text = " 参数设置";
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.参数设置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnConsume);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txt_topic);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_pwd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器信息";
            // 
            // btnConsume
            // 
            this.btnConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsume.Location = new System.Drawing.Point(582, 19);
            this.btnConsume.Name = "btnConsume";
            this.btnConsume.Size = new System.Drawing.Size(75, 41);
            this.btnConsume.TabIndex = 2;
            this.btnConsume.Text = "消费数据";
            this.btnConsume.UseVisualStyleBackColor = true;
            this.btnConsume.Click += new System.EventHandler(this.btnConsume_Click);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(468, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 41);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txt_topic
            // 
            this.txt_topic.Location = new System.Drawing.Point(78, 95);
            this.txt_topic.Name = "txt_topic";
            this.txt_topic.Size = new System.Drawing.Size(343, 21);
            this.txt_topic.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Topic：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(300, 59);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(121, 21);
            this.txt_pwd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密  码：";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(78, 59);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(121, 21);
            this.txt_username.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用户名：";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(300, 19);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(121, 21);
            this.txt_port.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器端口：";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(78, 22);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(121, 21);
            this.txt_ip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器IP：";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpage_send);
            this.tabControl.Controls.Add(this.tabPage_consume);
            this.tabControl.Controls.Add(this.tabpage_s);
            this.tabControl.Location = new System.Drawing.Point(13, 234);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 433);
            this.tabControl.TabIndex = 3;
            // 
            // tabpage_send
            // 
            this.tabpage_send.Controls.Add(this.txt_sendcontent);
            this.tabpage_send.Controls.Add(this.txt_send);
            this.tabpage_send.Controls.Add(this.label8);
            this.tabpage_send.Controls.Add(this.label7);
            this.tabpage_send.Location = new System.Drawing.Point(4, 22);
            this.tabpage_send.Name = "tabpage_send";
            this.tabpage_send.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_send.Size = new System.Drawing.Size(665, 407);
            this.tabpage_send.TabIndex = 0;
            this.tabpage_send.Text = "向MQ发送数据";
            this.tabpage_send.UseVisualStyleBackColor = true;
            // 
            // txt_sendcontent
            // 
            this.txt_sendcontent.Location = new System.Drawing.Point(3, 29);
            this.txt_sendcontent.Multiline = true;
            this.txt_sendcontent.Name = "txt_sendcontent";
            this.txt_sendcontent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_sendcontent.Size = new System.Drawing.Size(653, 209);
            this.txt_sendcontent.TabIndex = 0;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(6, 268);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_send.Size = new System.Drawing.Size(653, 133);
            this.txt_send.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "日志：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送内容：";
            // 
            // tabPage_consume
            // 
            this.tabPage_consume.Controls.Add(this.txt_consume);
            this.tabPage_consume.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consume.Name = "tabPage_consume";
            this.tabPage_consume.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consume.Size = new System.Drawing.Size(665, 407);
            this.tabPage_consume.TabIndex = 1;
            this.tabPage_consume.Text = "MQ消费数据";
            this.tabPage_consume.UseVisualStyleBackColor = true;
            // 
            // txt_consume
            // 
            this.txt_consume.Location = new System.Drawing.Point(3, 5);
            this.txt_consume.Multiline = true;
            this.txt_consume.Name = "txt_consume";
            this.txt_consume.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_consume.Size = new System.Drawing.Size(659, 396);
            this.txt_consume.TabIndex = 1;
            // 
            // chb_guid
            // 
            this.chb_guid.AutoSize = true;
            this.chb_guid.Location = new System.Drawing.Point(6, 20);
            this.chb_guid.Name = "chb_guid";
            this.chb_guid.Size = new System.Drawing.Size(96, 16);
            this.chb_guid.TabIndex = 3;
            this.chb_guid.Text = "是否使用guid";
            this.chb_guid.UseVisualStyleBackColor = true;
            // 
            // chb_random
            // 
            this.chb_random.AutoSize = true;
            this.chb_random.Location = new System.Drawing.Point(6, 45);
            this.chb_random.Name = "chb_random";
            this.chb_random.Size = new System.Drawing.Size(108, 16);
            this.chb_random.TabIndex = 3;
            this.chb_random.Text = "是否使用随机数";
            this.chb_random.UseVisualStyleBackColor = true;
            // 
            // txt_guid
            // 
            this.txt_guid.Location = new System.Drawing.Point(112, 14);
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.Size = new System.Drawing.Size(100, 21);
            this.txt_guid.TabIndex = 4;
            this.txt_guid.Text = "#guid#";
            // 
            // txt_random
            // 
            this.txt_random.Location = new System.Drawing.Point(112, 40);
            this.txt_random.Name = "txt_random";
            this.txt_random.Size = new System.Drawing.Size(100, 21);
            this.txt_random.TabIndex = 4;
            this.txt_random.Text = "#random#";
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_t.ForeColor = System.Drawing.Color.Red;
            this.lbl_t.Location = new System.Drawing.Point(6, 72);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(117, 11);
            this.lbl_t.TabIndex = 5;
            this.lbl_t.Text = "- - 变量替换发送内容";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_t);
            this.groupBox2.Controls.Add(this.chb_guid);
            this.groupBox2.Controls.Add(this.txt_random);
            this.groupBox2.Controls.Add(this.chb_random);
            this.groupBox2.Controls.Add(this.txt_guid);
            this.groupBox2.Location = new System.Drawing.Point(449, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "随机数配置";
            // 
            // tabpage_s
            // 
            this.tabpage_s.Controls.Add(this.txt_param333);
            this.tabpage_s.Controls.Add(this.txt_param33);
            this.tabpage_s.Controls.Add(this.txt_param222);
            this.tabpage_s.Controls.Add(this.txt_param22);
            this.tabpage_s.Controls.Add(this.chb_param3);
            this.tabpage_s.Controls.Add(this.txt_param111);
            this.tabpage_s.Controls.Add(this.chb_param2);
            this.tabpage_s.Controls.Add(this.txt_param11);
            this.tabpage_s.Controls.Add(this.chb_param1);
            this.tabpage_s.Location = new System.Drawing.Point(4, 22);
            this.tabpage_s.Name = "tabpage_s";
            this.tabpage_s.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_s.Size = new System.Drawing.Size(665, 407);
            this.tabpage_s.TabIndex = 2;
            this.tabpage_s.Text = "全局变量设置";
            this.tabpage_s.UseVisualStyleBackColor = true;
            // 
            // txt_param11
            // 
            this.txt_param11.Location = new System.Drawing.Point(108, 21);
            this.txt_param11.Name = "txt_param11";
            this.txt_param11.Size = new System.Drawing.Size(100, 21);
            this.txt_param11.TabIndex = 4;
            this.txt_param11.Text = "#p1#";
            // 
            // chb_param1
            // 
            this.chb_param1.AutoSize = true;
            this.chb_param1.Location = new System.Drawing.Point(16, 26);
            this.chb_param1.Name = "chb_param1";
            this.chb_param1.Size = new System.Drawing.Size(72, 16);
            this.chb_param1.TabIndex = 3;
            this.chb_param1.Text = "是否启用";
            this.chb_param1.UseVisualStyleBackColor = true;
            // 
            // txt_param111
            // 
            this.txt_param111.Location = new System.Drawing.Point(221, 21);
            this.txt_param111.Name = "txt_param111";
            this.txt_param111.Size = new System.Drawing.Size(150, 21);
            this.txt_param111.TabIndex = 4;
            // 
            // chb_param2
            // 
            this.chb_param2.AutoSize = true;
            this.chb_param2.Location = new System.Drawing.Point(16, 64);
            this.chb_param2.Name = "chb_param2";
            this.chb_param2.Size = new System.Drawing.Size(72, 16);
            this.chb_param2.TabIndex = 3;
            this.chb_param2.Text = "是否启用";
            this.chb_param2.UseVisualStyleBackColor = true;
            // 
            // txt_param22
            // 
            this.txt_param22.Location = new System.Drawing.Point(108, 59);
            this.txt_param22.Name = "txt_param22";
            this.txt_param22.Size = new System.Drawing.Size(100, 21);
            this.txt_param22.TabIndex = 4;
            this.txt_param22.Text = "#p2#";
            // 
            // txt_param222
            // 
            this.txt_param222.Location = new System.Drawing.Point(221, 59);
            this.txt_param222.Name = "txt_param222";
            this.txt_param222.Size = new System.Drawing.Size(150, 21);
            this.txt_param222.TabIndex = 4;
            // 
            // chb_param3
            // 
            this.chb_param3.AutoSize = true;
            this.chb_param3.Location = new System.Drawing.Point(16, 100);
            this.chb_param3.Name = "chb_param3";
            this.chb_param3.Size = new System.Drawing.Size(72, 16);
            this.chb_param3.TabIndex = 3;
            this.chb_param3.Text = "是否启用";
            this.chb_param3.UseVisualStyleBackColor = true;
            // 
            // txt_param33
            // 
            this.txt_param33.Location = new System.Drawing.Point(108, 95);
            this.txt_param33.Name = "txt_param33";
            this.txt_param33.Size = new System.Drawing.Size(100, 21);
            this.txt_param33.TabIndex = 4;
            this.txt_param33.Text = "#p3#";
            // 
            // txt_param333
            // 
            this.txt_param333.Location = new System.Drawing.Point(221, 95);
            this.txt_param333.Name = "txt_param333";
            this.txt_param333.Size = new System.Drawing.Size(150, 21);
            this.txt_param333.TabIndex = 4;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 682);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Topic);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabpage_send.ResumeLayout(false);
            this.tabpage_send.PerformLayout();
            this.tabPage_consume.ResumeLayout(false);
            this.tabPage_consume.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpage_s.ResumeLayout(false);
            this.tabpage_s.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Topic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_topic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConsume;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpage_send;
        private System.Windows.Forms.TabPage tabPage_consume;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.TextBox txt_consume;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_sendcontent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_guid;
        private System.Windows.Forms.CheckBox chb_random;
        private System.Windows.Forms.TextBox txt_guid;
        private System.Windows.Forms.TextBox txt_random;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabpage_s;
        private System.Windows.Forms.TextBox txt_param111;
        private System.Windows.Forms.TextBox txt_param11;
        private System.Windows.Forms.CheckBox chb_param1;
        private System.Windows.Forms.TextBox txt_param333;
        private System.Windows.Forms.TextBox txt_param33;
        private System.Windows.Forms.TextBox txt_param222;
        private System.Windows.Forms.TextBox txt_param22;
        private System.Windows.Forms.CheckBox chb_param3;
        private System.Windows.Forms.CheckBox chb_param2;
    }
}