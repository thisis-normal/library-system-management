﻿using System.Windows.Forms;

namespace LMSProject
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStRefresh = new FlatButton.JFlatButton();
            this.btnStSearch = new FlatButton.JFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtStNumber = new System.Windows.Forms.TextBox();
            this.circularPicture3 = new LMSProject.CircularPicture();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circularPicture1 = new LMSProject.CircularPicture();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnbkreturn = new FlatButton.JFlatButton();
            this.jFlatButton5 = new FlatButton.JFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBkIssueDate = new System.Windows.Forms.TextBox();
            this.txtBkName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.stName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnStRefresh);
            this.panel5.Controls.Add(this.btnStSearch);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txtStNumber);
            this.panel5.Controls.Add(this.circularPicture3);
            this.panel5.Location = new System.Drawing.Point(43, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 364);
            this.panel5.TabIndex = 53;
            // 
            // btnStRefresh
            // 
            this.btnStRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnStRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnStRefresh.ButtonText = "Làm mới";
            this.btnStRefresh.CausesValidation = false;
            this.btnStRefresh.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnStRefresh.ErrorImageLeft")));
            this.btnStRefresh.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnStRefresh.ErrorImageRight")));
            this.btnStRefresh.FocusBackground = System.Drawing.Color.Empty;
            this.btnStRefresh.FocusFontColor = System.Drawing.Color.Empty;
            this.btnStRefresh.ForeColors = System.Drawing.Color.White;
            this.btnStRefresh.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnStRefresh.HoverFontColor = System.Drawing.Color.White;
            this.btnStRefresh.ImageLeft = null;
            this.btnStRefresh.ImageRight = null;
            this.btnStRefresh.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnStRefresh.Location = new System.Drawing.Point(68, 284);
            this.btnStRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnStRefresh.Name = "btnStRefresh";
            this.btnStRefresh.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnStRefresh.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnStRefresh.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnStRefresh.Size = new System.Drawing.Size(106, 41);
            this.btnStRefresh.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnStRefresh.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStRefresh.TabIndex = 32;
            this.btnStRefresh.Click += new System.EventHandler(this.btnStRefresh_Click);
            // 
            // btnStSearch
            // 
            this.btnStSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStSearch.ButtonText = "Tìm kiếm";
            this.btnStSearch.CausesValidation = false;
            this.btnStSearch.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnStSearch.ErrorImageLeft")));
            this.btnStSearch.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnStSearch.ErrorImageRight")));
            this.btnStSearch.FocusBackground = System.Drawing.Color.Empty;
            this.btnStSearch.FocusFontColor = System.Drawing.Color.Empty;
            this.btnStSearch.ForeColors = System.Drawing.Color.White;
            this.btnStSearch.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnStSearch.HoverFontColor = System.Drawing.Color.White;
            this.btnStSearch.ImageLeft = null;
            this.btnStSearch.ImageRight = null;
            this.btnStSearch.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnStSearch.Location = new System.Drawing.Point(61, 218);
            this.btnStSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnStSearch.Name = "btnStSearch";
            this.btnStSearch.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnStSearch.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnStSearch.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnStSearch.Size = new System.Drawing.Size(125, 52);
            this.btnStSearch.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnStSearch.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStSearch.TabIndex = 34;
            this.btnStSearch.Click += new System.EventHandler(this.btnStSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(74, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã sinh viên";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(37, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 2);
            this.panel7.TabIndex = 22;
            // 
            // txtStNumber
            // 
            this.txtStNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtStNumber.Location = new System.Drawing.Point(37, 178);
            this.txtStNumber.Name = "txtStNumber";
            this.txtStNumber.Size = new System.Drawing.Size(192, 23);
            this.txtStNumber.TabIndex = 21;
            this.txtStNumber.TextChanged += new System.EventHandler(this.txtStNumber_TextChanged);
            // 
            // circularPicture3
            // 
            this.circularPicture3.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture3.Image")));
            this.circularPicture3.Location = new System.Drawing.Point(61, 20);
            this.circularPicture3.Name = "circularPicture3";
            this.circularPicture3.Size = new System.Drawing.Size(125, 112);
            this.circularPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture3.TabIndex = 0;
            this.circularPicture3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.circularPicture1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 70);
            this.panel1.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-1, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 85);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 85);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // circularPicture1
            // 
            this.circularPicture1.Dock = System.Windows.Forms.DockStyle.Right;
            this.circularPicture1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("circularPicture1.ErrorImage")));
            this.circularPicture1.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture1.Image")));
            this.circularPicture1.Location = new System.Drawing.Point(964, 0);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(71, 70);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture1.TabIndex = 8;
            this.circularPicture1.TabStop = false;
            this.circularPicture1.Click += new System.EventHandler(this.circularPicture1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trả sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stName,
            this.stDepartment,
            this.stClass,
            this.stContact,
            this.stEmail,
            this.bookkName,
            this.bookIssueDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(332, 180);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(691, 174);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ngày mượn sách";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel12.Location = new System.Drawing.Point(239, 103);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(261, 2);
            this.panel12.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(97, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tên sách";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel13.Location = new System.Drawing.Point(239, 61);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(261, 2);
            this.panel13.TabIndex = 57;
            // 
            // returnDate
            // 
            this.returnDate.CustomFormat = "dd/MM/yyyy";
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(239, 118);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(261, 22);
            this.returnDate.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Ngày trả sách";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(239, 139);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 2);
            this.panel6.TabIndex = 63;
            // 
            // btnbkreturn
            // 
            this.btnbkreturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnbkreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnbkreturn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnbkreturn.ButtonText = "Xác nhận";
            this.btnbkreturn.CausesValidation = false;
            this.btnbkreturn.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnbkreturn.ErrorImageLeft")));
            this.btnbkreturn.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnbkreturn.ErrorImageRight")));
            this.btnbkreturn.FocusBackground = System.Drawing.Color.Empty;
            this.btnbkreturn.FocusFontColor = System.Drawing.Color.Empty;
            this.btnbkreturn.ForeColors = System.Drawing.Color.White;
            this.btnbkreturn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnbkreturn.HoverFontColor = System.Drawing.Color.White;
            this.btnbkreturn.ImageLeft = null;
            this.btnbkreturn.ImageRight = null;
            this.btnbkreturn.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnbkreturn.Location = new System.Drawing.Point(536, 37);
            this.btnbkreturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnbkreturn.Name = "btnbkreturn";
            this.btnbkreturn.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnbkreturn.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnbkreturn.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnbkreturn.Size = new System.Drawing.Size(126, 52);
            this.btnbkreturn.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnbkreturn.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnbkreturn.TabIndex = 66;
            this.btnbkreturn.Click += new System.EventHandler(this.btnbkreturn_Click);
            // 
            // jFlatButton5
            // 
            this.jFlatButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jFlatButton5.BackColor = System.Drawing.Color.Red;
            this.jFlatButton5.BackgroundColor = System.Drawing.Color.Red;
            this.jFlatButton5.ButtonText = "Làm mới sách";
            this.jFlatButton5.CausesValidation = false;
            this.jFlatButton5.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jFlatButton5.ErrorImageLeft")));
            this.jFlatButton5.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jFlatButton5.ErrorImageRight")));
            this.jFlatButton5.FocusBackground = System.Drawing.Color.Empty;
            this.jFlatButton5.FocusFontColor = System.Drawing.Color.Empty;
            this.jFlatButton5.ForeColors = System.Drawing.Color.White;
            this.jFlatButton5.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.jFlatButton5.HoverFontColor = System.Drawing.Color.White;
            this.jFlatButton5.ImageLeft = null;
            this.jFlatButton5.ImageRight = null;
            this.jFlatButton5.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton5.Location = new System.Drawing.Point(536, 103);
            this.jFlatButton5.Margin = new System.Windows.Forms.Padding(4);
            this.jFlatButton5.Name = "jFlatButton5";
            this.jFlatButton5.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton5.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jFlatButton5.RightPictureColor = System.Drawing.Color.Transparent;
            this.jFlatButton5.Size = new System.Drawing.Size(126, 52);
            this.jFlatButton5.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jFlatButton5.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jFlatButton5.TabIndex = 67;
            this.jFlatButton5.Click += new System.EventHandler(this.jFlatButton5_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txtBkIssueDate);
            this.panel8.Controls.Add(this.txtBkName);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnbkreturn);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.jFlatButton5);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.returnDate);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(332, 370);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(691, 174);
            this.panel8.TabIndex = 68;
            // 
            // txtBkIssueDate
            // 
            this.txtBkIssueDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBkIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtBkIssueDate.Location = new System.Drawing.Point(239, 79);
            this.txtBkIssueDate.Name = "txtBkIssueDate";
            this.txtBkIssueDate.Size = new System.Drawing.Size(261, 23);
            this.txtBkIssueDate.TabIndex = 69;
            // 
            // txtBkName
            // 
            this.txtBkName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtBkName.Location = new System.Drawing.Point(239, 37);
            this.txtBkName.Name = "txtBkName";
            this.txtBkName.Size = new System.Drawing.Size(261, 23);
            this.txtBkName.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Location = new System.Drawing.Point(43, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 94);
            this.panel4.TabIndex = 55;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.pictureBox10);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Controls.Add(this.pictureBox7);
            this.panel9.Location = new System.Drawing.Point(-32, -1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1011, 94);
            this.panel9.TabIndex = 56;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(756, 22);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 57);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(255, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(441, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(124, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // stName
            // 
            this.stName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stName.DataPropertyName = "stName";
            this.stName.HeaderText = "Tên sinh viên";
            this.stName.Name = "stName";
            // 
            // stDepartment
            // 
            this.stDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stDepartment.DataPropertyName = "stDepartment";
            this.stDepartment.HeaderText = "Khoa";
            this.stDepartment.Name = "stDepartment";
            // 
            // stClass
            // 
            this.stClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stClass.DataPropertyName = "stSemester";
            this.stClass.HeaderText = "Lớp niên chế";
            this.stClass.Name = "stClass";
            // 
            // stContact
            // 
            this.stContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stContact.DataPropertyName = "stContact";
            this.stContact.HeaderText = "Số điện thoại";
            this.stContact.Name = "stContact";
            // 
            // stEmail
            // 
            this.stEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stEmail.DataPropertyName = "stEmail";
            this.stEmail.HeaderText = "Email";
            this.stEmail.Name = "stEmail";
            // 
            // bookkName
            // 
            this.bookkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookkName.DataPropertyName = "bkName";
            this.bookkName.HeaderText = "Tên sách";
            this.bookkName.Name = "bookkName";
            // 
            // bookIssueDate
            // 
            this.bookIssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookIssueDate.DataPropertyName = "bkIssueDate";
            this.bookIssueDate.HeaderText = "Ngày mượn sách";
            this.bookIssueDate.Name = "bookIssueDate";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 580);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReurnBook";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private FlatButton.JFlatButton btnStRefresh;
        private FlatButton.JFlatButton btnStSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtStNumber;
        private CircularPicture circularPicture3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CircularPicture circularPicture1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private FlatButton.JFlatButton btnbkreturn;
        private FlatButton.JFlatButton jFlatButton5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtBkIssueDate;
        private System.Windows.Forms.TextBox txtBkName;
        private DataGridViewTextBoxColumn stName;
        private DataGridViewTextBoxColumn stDepartment;
        private DataGridViewTextBoxColumn stClass;
        private DataGridViewTextBoxColumn stContact;
        private DataGridViewTextBoxColumn stEmail;
        private DataGridViewTextBoxColumn bookkName;
        private DataGridViewTextBoxColumn bookIssueDate;
    }
}