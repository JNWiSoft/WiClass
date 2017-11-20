namespace WiClass
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlToolsbar = new System.Windows.Forms.Panel();
            this.ucInteract = new WiClass.UControl.ucMenuItem();
            this.ucMini = new WiClass.UControl.ucMenuItem();
            this.ucRedo = new WiClass.UControl.ucMenuItem();
            this.ucBack = new WiClass.UControl.ucMenuItem();
            this.ucBackground = new WiClass.UControl.ucMenuItem();
            this.ucTools = new WiClass.UControl.ucMenuItem();
            this.ucSelect = new WiClass.UControl.ucMenuItem();
            this.ucEraser = new WiClass.UControl.ucMenuItem();
            this.ucPen = new WiClass.UControl.ucMenuItem();
            this.picStartMenuico = new System.Windows.Forms.PictureBox();
            this.cmsStartMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInterPanel = new System.Windows.Forms.Panel();
            this.pnlStudentlist = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTest = new WiClass.UControl.ucInterButton();
            this.btnChoice = new WiClass.UControl.ucInterButton();
            this.btnWrite = new WiClass.UControl.ucInterButton();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlIntertitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picTitleIco = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlToolsbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStartMenuico)).BeginInit();
            this.cmsStartMenu.SuspendLayout();
            this.pnlInterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlIntertitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolsbar
            // 
            this.pnlToolsbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToolsbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.pnlToolsbar.Controls.Add(this.ucInteract);
            this.pnlToolsbar.Controls.Add(this.ucMini);
            this.pnlToolsbar.Controls.Add(this.ucRedo);
            this.pnlToolsbar.Controls.Add(this.ucBack);
            this.pnlToolsbar.Controls.Add(this.ucBackground);
            this.pnlToolsbar.Controls.Add(this.ucTools);
            this.pnlToolsbar.Controls.Add(this.ucSelect);
            this.pnlToolsbar.Controls.Add(this.ucEraser);
            this.pnlToolsbar.Controls.Add(this.ucPen);
            this.pnlToolsbar.Controls.Add(this.picStartMenuico);
            this.pnlToolsbar.Location = new System.Drawing.Point(0, 556);
            this.pnlToolsbar.Name = "pnlToolsbar";
            this.pnlToolsbar.Size = new System.Drawing.Size(1336, 66);
            this.pnlToolsbar.TabIndex = 0;
            // 
            // ucInteract
            // 
            this.ucInteract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInteract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.ucInteract.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.ucInteract.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ucInteract.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucInteract.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ucInteract.Imagesurl = global::WiClass.Properties.Resources.interaction;
            this.ucInteract.ItemText = "互动";
            this.ucInteract.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.ucInteract.Location = new System.Drawing.Point(1269, 0);
            this.ucInteract.Margin = new System.Windows.Forms.Padding(0);
            this.ucInteract.Name = "ucInteract";
            this.ucInteract.Size = new System.Drawing.Size(66, 66);
            this.ucInteract.TabIndex = 8;
            this.ucInteract.Click += new System.EventHandler(this.ucInteract_Click);
            // 
            // ucMini
            // 
            this.ucMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucMini.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucMini.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucMini.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucMini.Imagesurl = global::WiClass.Properties.Resources.mini;
            this.ucMini.ItemText = "桌面";
            this.ucMini.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucMini.Location = new System.Drawing.Point(895, 0);
            this.ucMini.Name = "ucMini";
            this.ucMini.Size = new System.Drawing.Size(66, 66);
            this.ucMini.TabIndex = 7;
            this.ucMini.Click += new System.EventHandler(this.ucMini_Click);
            // 
            // ucRedo
            // 
            this.ucRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucRedo.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucRedo.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucRedo.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucRedo.Imagesurl = global::WiClass.Properties.Resources.redo;
            this.ucRedo.ItemText = "恢复";
            this.ucRedo.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucRedo.Location = new System.Drawing.Point(827, 0);
            this.ucRedo.Name = "ucRedo";
            this.ucRedo.Size = new System.Drawing.Size(66, 66);
            this.ucRedo.TabIndex = 6;
            // 
            // ucBack
            // 
            this.ucBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBack.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBack.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucBack.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucBack.Imagesurl = global::WiClass.Properties.Resources.back;
            this.ucBack.ItemText = "撤销";
            this.ucBack.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBack.Location = new System.Drawing.Point(759, 0);
            this.ucBack.Name = "ucBack";
            this.ucBack.Size = new System.Drawing.Size(66, 66);
            this.ucBack.TabIndex = 5;
            // 
            // ucBackground
            // 
            this.ucBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBackground.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBackground.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucBackground.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucBackground.Imagesurl = global::WiClass.Properties.Resources.background;
            this.ucBackground.ItemText = "背景";
            this.ucBackground.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucBackground.Location = new System.Drawing.Point(691, 0);
            this.ucBackground.Name = "ucBackground";
            this.ucBackground.Size = new System.Drawing.Size(66, 66);
            this.ucBackground.TabIndex = 4;
            // 
            // ucTools
            // 
            this.ucTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucTools.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucTools.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucTools.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucTools.Imagesurl = global::WiClass.Properties.Resources.tools;
            this.ucTools.ItemText = "工具";
            this.ucTools.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucTools.Location = new System.Drawing.Point(623, 0);
            this.ucTools.Name = "ucTools";
            this.ucTools.Size = new System.Drawing.Size(66, 66);
            this.ucTools.TabIndex = 3;
            // 
            // ucSelect
            // 
            this.ucSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucSelect.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucSelect.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucSelect.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucSelect.Imagesurl = global::WiClass.Properties.Resources.select;
            this.ucSelect.ItemText = "选择";
            this.ucSelect.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucSelect.Location = new System.Drawing.Point(419, 0);
            this.ucSelect.Name = "ucSelect";
            this.ucSelect.Size = new System.Drawing.Size(66, 66);
            this.ucSelect.TabIndex = 1;
            // 
            // ucEraser
            // 
            this.ucEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucEraser.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucEraser.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucEraser.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucEraser.Imagesurl = global::WiClass.Properties.Resources.eraser;
            this.ucEraser.ItemText = "橡皮";
            this.ucEraser.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucEraser.Location = new System.Drawing.Point(555, 0);
            this.ucEraser.Name = "ucEraser";
            this.ucEraser.Size = new System.Drawing.Size(66, 66);
            this.ucEraser.TabIndex = 2;
            // 
            // ucPen
            // 
            this.ucPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucPen.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucPen.Entercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucPen.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ucPen.Imagesurl = global::WiClass.Properties.Resources.pen;
            this.ucPen.ItemText = "画笔";
            this.ucPen.Leavecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ucPen.Location = new System.Drawing.Point(487, 0);
            this.ucPen.Name = "ucPen";
            this.ucPen.Size = new System.Drawing.Size(66, 66);
            this.ucPen.TabIndex = 1;
            // 
            // picStartMenuico
            // 
            this.picStartMenuico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.picStartMenuico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStartMenuico.BackgroundImage")));
            this.picStartMenuico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picStartMenuico.Location = new System.Drawing.Point(0, 0);
            this.picStartMenuico.Name = "picStartMenuico";
            this.picStartMenuico.Padding = new System.Windows.Forms.Padding(5);
            this.picStartMenuico.Size = new System.Drawing.Size(66, 66);
            this.picStartMenuico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStartMenuico.TabIndex = 0;
            this.picStartMenuico.TabStop = false;
            this.picStartMenuico.Click += new System.EventHandler(this.picStartMenuico_Click);
            this.picStartMenuico.MouseEnter += new System.EventHandler(this.picStartMenuico_MouseEnter);
            this.picStartMenuico.MouseLeave += new System.EventHandler(this.picStartMenuico_MouseLeave);
            this.picStartMenuico.MouseHover += new System.EventHandler(this.picStartMenuico_MouseHover);
            // 
            // cmsStartMenu
            // 
            this.cmsStartMenu.DropShadowEnabled = false;
            this.cmsStartMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiOutput,
            this.tsmiSetting,
            this.tsmiHelp,
            this.tsmiLogout});
            this.cmsStartMenu.Name = "contextMenuStrip1";
            this.cmsStartMenu.Size = new System.Drawing.Size(148, 220);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiOpen.Image = global::WiClass.Properties.Resources.open;
            this.tsmiOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(147, 36);
            this.tsmiOpen.Text = "打开板书";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiSave.Image = global::WiClass.Properties.Resources.save;
            this.tsmiSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(147, 36);
            this.tsmiSave.Text = "保存板书";
            // 
            // tsmiOutput
            // 
            this.tsmiOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiOutput.Image = global::WiClass.Properties.Resources.output;
            this.tsmiOutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiOutput.Name = "tsmiOutput";
            this.tsmiOutput.Size = new System.Drawing.Size(147, 36);
            this.tsmiOutput.Text = "导出课堂";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiSetting.Image = global::WiClass.Properties.Resources.setting;
            this.tsmiSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(147, 36);
            this.tsmiSetting.Text = "系统设置";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMan,
            this.tsmiAbout});
            this.tsmiHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHelp.Image")));
            this.tsmiHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(147, 36);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiMan
            // 
            this.tsmiMan.Name = "tsmiMan";
            this.tsmiMan.Size = new System.Drawing.Size(134, 24);
            this.tsmiMan.Text = "使用说明";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(134, 24);
            this.tsmiAbout.Text = "关于";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tsmiLogout.Image = global::WiClass.Properties.Resources.logout;
            this.tsmiLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(147, 36);
            this.tsmiLogout.Text = "退出";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // pnlInterPanel
            // 
            this.pnlInterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInterPanel.Controls.Add(this.pnlStudentlist);
            this.pnlInterPanel.Controls.Add(this.pnlLine1);
            this.pnlInterPanel.Controls.Add(this.panel2);
            this.pnlInterPanel.Controls.Add(this.pnlInformation);
            this.pnlInterPanel.Controls.Add(this.pnlIntertitle);
            this.pnlInterPanel.Location = new System.Drawing.Point(961, 0);
            this.pnlInterPanel.Name = "pnlInterPanel";
            this.pnlInterPanel.Size = new System.Drawing.Size(375, 556);
            this.pnlInterPanel.TabIndex = 2;
            this.pnlInterPanel.Visible = false;
            // 
            // pnlStudentlist
            // 
            this.pnlStudentlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudentlist.BackColor = System.Drawing.Color.DimGray;
            this.pnlStudentlist.Location = new System.Drawing.Point(0, 290);
            this.pnlStudentlist.Name = "pnlStudentlist";
            this.pnlStudentlist.Size = new System.Drawing.Size(375, 187);
            this.pnlStudentlist.TabIndex = 4;
            // 
            // pnlLine1
            // 
            this.pnlLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine1.BackColor = System.Drawing.Color.LightGray;
            this.pnlLine1.Location = new System.Drawing.Point(0, 477);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(375, 1);
            this.pnlLine1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTest);
            this.panel2.Controls.Add(this.btnChoice);
            this.panel2.Controls.Add(this.btnWrite);
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 80);
            this.panel2.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.btnTest.Blselected = false;
            this.btnTest.ForeColor = System.Drawing.Color.Black;
            this.btnTest.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnTest.Imagesurl = global::WiClass.Properties.Resources.test11;
            this.btnTest.Itemtext = "测试";
            this.btnTest.Location = new System.Drawing.Point(261, 10);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(66, 66);
            this.btnTest.TabIndex = 2;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.btnChoice.Blselected = false;
            this.btnChoice.ForeColor = System.Drawing.Color.Black;
            this.btnChoice.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnChoice.Imagesurl = global::WiClass.Properties.Resources.choice6;
            this.btnChoice.Itemtext = "选择";
            this.btnChoice.Location = new System.Drawing.Point(155, 10);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(66, 66);
            this.btnChoice.TabIndex = 1;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Bgcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.btnWrite.Blselected = false;
            this.btnWrite.ForeColor = System.Drawing.Color.Black;
            this.btnWrite.Hovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnWrite.Imagesurl = global::WiClass.Properties.Resources.write;
            this.btnWrite.Itemtext = "书写";
            this.btnWrite.Location = new System.Drawing.Point(49, 10);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(66, 66);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // pnlInformation
            // 
            this.pnlInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformation.BackColor = System.Drawing.Color.White;
            this.pnlInformation.Location = new System.Drawing.Point(0, 40);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(375, 250);
            this.pnlInformation.TabIndex = 1;
            // 
            // pnlIntertitle
            // 
            this.pnlIntertitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIntertitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.pnlIntertitle.Controls.Add(this.lblTitle);
            this.pnlIntertitle.Controls.Add(this.picTitleIco);
            this.pnlIntertitle.Location = new System.Drawing.Point(0, 0);
            this.pnlIntertitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIntertitle.Name = "pnlIntertitle";
            this.pnlIntertitle.Size = new System.Drawing.Size(375, 40);
            this.pnlIntertitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(28, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "课堂互动";
            // 
            // picTitleIco
            // 
            this.picTitleIco.Image = ((System.Drawing.Image)(resources.GetObject("picTitleIco.Image")));
            this.picTitleIco.Location = new System.Drawing.Point(5, 10);
            this.picTitleIco.Name = "picTitleIco";
            this.picTitleIco.Size = new System.Drawing.Size(20, 20);
            this.picTitleIco.TabIndex = 0;
            this.picTitleIco.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1336, 557);
            this.picBackground.TabIndex = 1;
            this.picBackground.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 622);
            this.Controls.Add(this.pnlInterPanel);
            this.Controls.Add(this.pnlToolsbar);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlToolsbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStartMenuico)).EndInit();
            this.cmsStartMenu.ResumeLayout(false);
            this.pnlInterPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlIntertitle.ResumeLayout(false);
            this.pnlIntertitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolsbar;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picStartMenuico;
        private UControl.ucMenuItem ucSelect;
        private UControl.ucMenuItem ucPen;
        private UControl.ucMenuItem ucEraser;
        private UControl.ucMenuItem ucTools;
        private UControl.ucMenuItem ucBackground;
        private UControl.ucMenuItem ucBack;
        private UControl.ucMenuItem ucRedo;
        private UControl.ucMenuItem ucMini;
        private UControl.ucMenuItem ucInteract;
        private System.Windows.Forms.ContextMenuStrip cmsStartMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOutput;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMan;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.Panel pnlInterPanel;
        private System.Windows.Forms.Panel pnlIntertitle;
        private System.Windows.Forms.PictureBox picTitleIco;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel panel2;

        private UControl.ucInterButton btnTest;
        private UControl.ucInterButton btnChoice;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlStudentlist;
        private UControl.ucInterButton btnWrite;
    }
}