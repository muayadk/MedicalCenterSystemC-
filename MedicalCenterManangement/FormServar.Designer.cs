namespace MedicalCenterManangement
{
    partial class FormServar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd_Unit = new System.Windows.Forms.Button();
            this.tx_sql = new System.Windows.Forms.TextBox();
            this.cmState = new System.Windows.Forms.ComboBox();
            this.conn_type = new System.Windows.Forms.ComboBox();
            this.cmpath = new System.Windows.Forms.ComboBox();
            this.cmYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_db_out = new System.Windows.Forms.RadioButton();
            this.ch_db_in = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(410, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسم قاعدة البيانات";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 20.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(-74, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 35);
            this.label7.TabIndex = 50;
            this.label7.Text = "....";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(59, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(313, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 11.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(342, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "نوع الاتصال";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd_Unit);
            this.groupBox3.Controls.Add(this.tx_sql);
            this.groupBox3.Controls.Add(this.cmState);
            this.groupBox3.Controls.Add(this.conn_type);
            this.groupBox3.Controls.Add(this.cmpath);
            this.groupBox3.Controls.Add(this.cmYear);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ch_db_out);
            this.groupBox3.Controls.Add(this.ch_db_in);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(410, 113);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الاتصال";
            this.groupBox3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // btnAdd_Unit
            // 
            this.btnAdd_Unit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd_Unit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Unit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Unit.Image = global::MedicalCenterManangement.Properties.Resources._short;
            this.btnAdd_Unit.Location = new System.Drawing.Point(33, 81);
            this.btnAdd_Unit.Name = "btnAdd_Unit";
            this.btnAdd_Unit.Size = new System.Drawing.Size(28, 24);
            this.btnAdd_Unit.TabIndex = 62;
            this.btnAdd_Unit.UseVisualStyleBackColor = true;
            this.btnAdd_Unit.Click += new System.EventHandler(this.btnAdd_Unit_Click);
            // 
            // tx_sql
            // 
            this.tx_sql.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tx_sql.BackColor = System.Drawing.Color.White;
            this.tx_sql.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tx_sql.Location = new System.Drawing.Point(66, 49);
            this.tx_sql.Name = "tx_sql";
            this.tx_sql.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tx_sql.Size = new System.Drawing.Size(214, 26);
            this.tx_sql.TabIndex = 61;
            this.tx_sql.TextChanged += new System.EventHandler(this.tx_sql_TextChanged);
            this.tx_sql.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_sql_KeyPress);
            this.tx_sql.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_sql_KeyUp);
            this.tx_sql.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tx_sql_PreviewKeyDown);
            // 
            // cmState
            // 
            this.cmState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmState.FormattingEnabled = true;
            this.cmState.Location = new System.Drawing.Point(11, 39);
            this.cmState.Name = "cmState";
            this.cmState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmState.Size = new System.Drawing.Size(46, 24);
            this.cmState.TabIndex = 60;
            this.cmState.Visible = false;
            // 
            // conn_type
            // 
            this.conn_type.FormattingEnabled = true;
            this.conn_type.Location = new System.Drawing.Point(11, 13);
            this.conn_type.Name = "conn_type";
            this.conn_type.Size = new System.Drawing.Size(46, 21);
            this.conn_type.TabIndex = 59;
            this.conn_type.Visible = false;
            // 
            // cmpath
            // 
            this.cmpath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpath.FormattingEnabled = true;
            this.cmpath.Location = new System.Drawing.Point(11, 40);
            this.cmpath.Name = "cmpath";
            this.cmpath.Size = new System.Drawing.Size(46, 24);
            this.cmpath.TabIndex = 58;
            this.cmpath.Visible = false;
            this.cmpath.SelectedIndexChanged += new System.EventHandler(this.cmpath_SelectedIndexChanged);
            // 
            // cmYear
            // 
            this.cmYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmYear.BackColor = System.Drawing.SystemColors.Control;
            this.cmYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmYear.FormattingEnabled = true;
            this.cmYear.Location = new System.Drawing.Point(66, 81);
            this.cmYear.Name = "cmYear";
            this.cmYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmYear.Size = new System.Drawing.Size(214, 24);
            this.cmYear.TabIndex = 57;
            this.cmYear.SelectedIndexChanged += new System.EventHandler(this.cmYear_SelectedIndexChanged);
            this.cmYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 11.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(295, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "اختر قاعدة البيانات";
            this.label4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // ch_db_out
            // 
            this.ch_db_out.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ch_db_out.AutoSize = true;
            this.ch_db_out.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.ch_db_out.Location = new System.Drawing.Point(181, 17);
            this.ch_db_out.Name = "ch_db_out";
            this.ch_db_out.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_db_out.Size = new System.Drawing.Size(77, 29);
            this.ch_db_out.TabIndex = 53;
            this.ch_db_out.Text = "(server)";
            this.ch_db_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ch_db_out.UseVisualStyleBackColor = true;
            this.ch_db_out.CheckedChanged += new System.EventHandler(this.ch_db_out_CheckedChanged);
            this.ch_db_out.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // ch_db_in
            // 
            this.ch_db_in.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ch_db_in.AutoSize = true;
            this.ch_db_in.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.ch_db_in.Location = new System.Drawing.Point(264, 17);
            this.ch_db_in.Name = "ch_db_in";
            this.ch_db_in.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_db_in.Size = new System.Drawing.Size(70, 29);
            this.ch_db_in.TabIndex = 52;
            this.ch_db_in.Text = "(local)";
            this.ch_db_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ch_db_in.UseVisualStyleBackColor = true;
            this.ch_db_in.CheckedChanged += new System.EventHandler(this.ch_db_in_CheckedChanged);
            this.ch_db_in.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 11.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(295, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "اسم مخدم البيانات";
            this.label3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(0, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(404, 123);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اتصل باستخدام";
            this.groupBox4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Location = new System.Drawing.Point(14, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "label10";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.Location = new System.Drawing.Point(14, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(215, 20);
            this.txtPassword.TabIndex = 58;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUserName.Location = new System.Drawing.Point(14, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 20);
            this.txtUserName.TabIndex = 57;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 11.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(258, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 56;
            this.label9.Text = "كلمة المرور";
            this.label9.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sakkal Majalla", 11.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(254, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 55;
            this.label8.Text = "اسم المستخدم";
            this.label8.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(244, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(142, 28);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "اسم مستخدم ويندوز";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(209, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(177, 28);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.Text = " اسم مستخدم SQL Server";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Sakkal Majalla", 14.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = global::MedicalCenterManangement.Properties.Resources.login8888;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(100, 324);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 37);
            this.btnLogin.TabIndex = 52;
            this.btnLogin.Text = "استمرار";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.EnabledChanged += new System.EventHandler(this.btnLogin_EnabledChanged);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 14.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::MedicalCenterManangement.Properties.Resources.im_exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 53;
            this.button1.Text = "خــــــــروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 340);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 62;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripLabel2.Font = new System.Drawing.Font("Sakkal Majalla", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(149, 22);
            this.toolStripLabel2.Text = "عرض كل القواعد shift+enter";
            // 
            // FormServar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServar";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الاتصال بالمخدم";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServar_FormClosing);
            this.Load += new System.EventHandler(this.FormServar_Load);
            this.Shown += new System.EventHandler(this.FormServar_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ch_db_out;
        private System.Windows.Forms.RadioButton ch_db_in;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.ComboBox cmpath;
        public System.Windows.Forms.ComboBox cmYear;
        public System.Windows.Forms.ComboBox conn_type;
        public System.Windows.Forms.ComboBox cmState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tx_sql;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnAdd_Unit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}