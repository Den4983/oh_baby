﻿
namespace UI_Design
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaby = new System.Windows.Forms.Label();
            this.cmbBoxNameChild = new System.Windows.Forms.ComboBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnGrowth = new System.Windows.Forms.Button();
            this.BtnMed = new System.Windows.Forms.Button();
            this.BtnDocuments = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddChild = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblTmp = new System.Windows.Forms.Label();
>>>>>>> devSerg
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnGrowth);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.BtnMed);
            this.panel1.Controls.Add(this.BtnDocuments);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 800);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 249);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 80);
            this.pnlNav.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBaby);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmbBoxNameChild);
            this.panel2.Controls.Add(this.btnAddChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 249);
            this.panel2.TabIndex = 0;
            // 
            // lblBaby
            // 
            this.lblBaby.AutoSize = true;
            this.lblBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBaby.Location = new System.Drawing.Point(21, 89);
            this.lblBaby.Name = "lblBaby";
            this.lblBaby.Size = new System.Drawing.Size(0, 20);
            this.lblBaby.TabIndex = 1;
            // 
            // cmbBoxNameChild
            // 
            this.cmbBoxNameChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxNameChild.Enabled = false;
            this.cmbBoxNameChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxNameChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxNameChild.FormattingEnabled = true;
            this.cmbBoxNameChild.Location = new System.Drawing.Point(12, 164);
            this.cmbBoxNameChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxNameChild.Name = "cmbBoxNameChild";
            this.cmbBoxNameChild.Size = new System.Drawing.Size(273, 37);
            this.cmbBoxNameChild.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.cmbBoxNameChild, "Выберете ребенка для просмотра его данных");
            this.cmbBoxNameChild.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameChild_SelectedIndexChanged);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(291, 150);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1309, 650);
            this.pnlFormLoader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTitle.Location = new System.Drawing.Point(779, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "> Главная <";
            // 
            // toolTipMain
            // 
            this.toolTipMain.AutomaticDelay = 100;
            this.toolTipMain.AutoPopDelay = 5000;
            this.toolTipMain.InitialDelay = 100;
            this.toolTipMain.ReshowDelay = 20;
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblLogo
            // 
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogo.Image = global::UI_Design.Properties.Resources.logo2;
            this.lblLogo.Location = new System.Drawing.Point(721, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(331, 80);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnSettings.Image = global::UI_Design.Properties.Resources.automation_48px;
<<<<<<< HEAD
            this.BtnSettings.Location = new System.Drawing.Point(0, 640);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnSettings.Location = new System.Drawing.Point(0, 520);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(291, 80);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.Text = "> Свойства  ";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnExit.Image = global::UI_Design.Properties.Resources.exit_64_1px;
<<<<<<< HEAD
            this.BtnExit.Location = new System.Drawing.Point(0, 720);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnExit.Location = new System.Drawing.Point(0, 585);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(291, 80);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "> Выход     ";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnGrowth
            // 
            this.BtnGrowth.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnGrowth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGrowth.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrowth.FlatAppearance.BorderSize = 0;
            this.BtnGrowth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGrowth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnGrowth.Image = global::UI_Design.Properties.Resources.increase_48px;
<<<<<<< HEAD
            this.BtnGrowth.Location = new System.Drawing.Point(0, 489);
            this.BtnGrowth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnGrowth.Location = new System.Drawing.Point(0, 397);
            this.BtnGrowth.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnGrowth.Name = "BtnGrowth";
            this.BtnGrowth.Size = new System.Drawing.Size(291, 80);
            this.BtnGrowth.TabIndex = 4;
            this.BtnGrowth.Text = "> Развитие   ";
            this.BtnGrowth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnGrowth.UseVisualStyleBackColor = true;
            this.BtnGrowth.Click += new System.EventHandler(this.BtnGrowth_Click);
            this.BtnGrowth.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
<<<<<<< HEAD
=======
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 202);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 65);
            this.pnlNav.TabIndex = 1;
            // 
>>>>>>> devSerg
            // BtnMed
            // 
            this.BtnMed.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMed.FlatAppearance.BorderSize = 0;
            this.BtnMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnMed.Image = global::UI_Design.Properties.Resources.treatment_64_1px;
<<<<<<< HEAD
            this.BtnMed.Location = new System.Drawing.Point(0, 409);
            this.BtnMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnMed.Location = new System.Drawing.Point(0, 332);
            this.BtnMed.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnMed.Name = "BtnMed";
            this.BtnMed.Size = new System.Drawing.Size(291, 80);
            this.BtnMed.TabIndex = 3;
            this.BtnMed.Text = "> Медицина  ";
            this.BtnMed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnMed.UseVisualStyleBackColor = true;
            this.BtnMed.Click += new System.EventHandler(this.BtnMed_Click);
            this.BtnMed.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // BtnDocuments
            // 
            this.BtnDocuments.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocuments.FlatAppearance.BorderSize = 0;
            this.BtnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnDocuments.Image = global::UI_Design.Properties.Resources.document_64_1px;
<<<<<<< HEAD
            this.BtnDocuments.Location = new System.Drawing.Point(0, 329);
            this.BtnDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnDocuments.Location = new System.Drawing.Point(0, 267);
            this.BtnDocuments.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnDocuments.Name = "BtnDocuments";
            this.BtnDocuments.Size = new System.Drawing.Size(291, 80);
            this.BtnDocuments.TabIndex = 2;
            this.BtnDocuments.Text = "> Документы";
            this.BtnDocuments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDocuments.UseVisualStyleBackColor = true;
            this.BtnDocuments.Click += new System.EventHandler(this.BtnDocuments_Click);
            this.BtnDocuments.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
            // BtnHome
            // 
            this.BtnHome.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_5;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.BtnHome.Image = global::UI_Design.Properties.Resources.home_64_1px;
<<<<<<< HEAD
            this.BtnHome.Location = new System.Drawing.Point(0, 249);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.BtnHome.Location = new System.Drawing.Point(0, 202);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(291, 80);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "> Главная     ";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
<<<<<<< HEAD
=======
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTmp);
            this.panel2.Controls.Add(this.lblBaby);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmbBoxNameChild);
            this.panel2.Controls.Add(this.btnAddChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 202);
            this.panel2.TabIndex = 0;
            // 
            // lblBaby
            // 
            this.lblBaby.AutoSize = true;
            this.lblBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblBaby.Location = new System.Drawing.Point(16, 72);
            this.lblBaby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaby.Name = "lblBaby";
            this.lblBaby.Size = new System.Drawing.Size(0, 17);
            this.lblBaby.TabIndex = 1;
            // 
>>>>>>> devSerg
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Design.Properties.Resources.babys_room_64px;
            this.pictureBox1.InitialImage = null;
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(81, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.pictureBox1.Location = new System.Drawing.Point(61, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
=======
            // cmbBoxNameChild
            // 
            this.cmbBoxNameChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.cmbBoxNameChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxNameChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbBoxNameChild.FormattingEnabled = true;
            this.cmbBoxNameChild.Location = new System.Drawing.Point(39, 132);
            this.cmbBoxNameChild.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxNameChild.Name = "cmbBoxNameChild";
            this.cmbBoxNameChild.Size = new System.Drawing.Size(144, 30);
            this.cmbBoxNameChild.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.cmbBoxNameChild, "Выберете ребенка для просмотра его данных");
            this.cmbBoxNameChild.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNameChild_SelectedIndexChanged);
            // 
>>>>>>> devSerg
            // btnAddChild
            // 
            this.btnAddChild.BackgroundImage = global::UI_Design.Properties.Resources.Untitled_9;
            this.btnAddChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddChild.FlatAppearance.BorderSize = 0;
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnAddChild.Image = global::UI_Design.Properties.Resources.add_50px2;
            this.btnAddChild.Location = new System.Drawing.Point(219, 0);
            this.btnAddChild.Margin = new System.Windows.Forms.Padding(11, 20, 3, 2);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(72, 69);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTipMain.SetToolTip(this.btnAddChild, "Нажмите для добавления учетной записи ребенка");
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            this.btnAddChild.Leave += new System.EventHandler(this.BtnAll_Leave);
            // 
<<<<<<< HEAD
=======
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(218, 122);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(982, 528);
            this.pnlFormLoader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTitle.Location = new System.Drawing.Point(584, 81);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "> Главная <";
            // 
            // lblLogo
            // 
            this.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogo.Image = global::UI_Design.Properties.Resources.logo2;
            this.lblLogo.Location = new System.Drawing.Point(541, 7);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(248, 65);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMain
            // 
            this.toolTipMain.AutomaticDelay = 100;
            this.toolTipMain.AutoPopDelay = 5000;
            this.toolTipMain.InitialDelay = 100;
            this.toolTipMain.ReshowDelay = 20;
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblParentName.Location = new System.Drawing.Point(924, 9);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(100, 31);
            this.lblParentName.TabIndex = 11;
            this.lblParentName.Text = "Parent";
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.lblTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblTmp.Location = new System.Drawing.Point(3, 164);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(110, 24);
            this.lblTmp.TabIndex = 9;
            this.lblTmp.Text = "label_Temp";
            this.lblTmp.Visible = false;
            // 
>>>>>>> devSerg
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1600, 800);
=======
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblParentName);
>>>>>>> devSerg
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> devSerg
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label lblBaby;
        private System.Windows.Forms.Button BtnGrowth;
        private System.Windows.Forms.Button BtnMed;
        private System.Windows.Forms.Button BtnDocuments;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ComboBox cmbBoxNameChild;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblTmp;
    }
}

