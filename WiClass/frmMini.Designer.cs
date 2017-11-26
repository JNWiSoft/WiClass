namespace WiClass
{
    partial class frmMini
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
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnLogoin = new System.Windows.Forms.Panel();
            this.ucMiniButton4 = new WiClass.UControl.ucMiniButton();
            this.ucMiniButton3 = new WiClass.UControl.ucMiniButton();
            this.ucMiniButton2 = new WiClass.UControl.ucMiniButton();
            this.ucMiniButton1 = new WiClass.UControl.ucMiniButton();
            this.ucSelect = new WiClass.UControl.ucMiniButton();
            this.pnLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.pnLogoin);
            this.pnLogo.Location = new System.Drawing.Point(12, 12);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(100, 100);
            this.pnLogo.TabIndex = 7;
            this.pnLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogo_Paint);
            // 
            // pnLogoin
            // 
            this.pnLogoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.pnLogoin.Location = new System.Drawing.Point(10, 10);
            this.pnLogoin.Name = "pnLogoin";
            this.pnLogoin.Size = new System.Drawing.Size(80, 80);
            this.pnLogoin.TabIndex = 0;
            this.pnLogoin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogoin_Paint);
            // 
            // ucMiniButton4
            // 
            this.ucMiniButton4.Bgcolor = System.Drawing.Color.Empty;
            this.ucMiniButton4.Blselected = false;
            this.ucMiniButton4.Hovercolor = System.Drawing.Color.Empty;
            this.ucMiniButton4.Imagesurl = global::WiClass.Properties.Resources.max;
            this.ucMiniButton4.Itemtext = null;
            this.ucMiniButton4.Location = new System.Drawing.Point(400, 33);
            this.ucMiniButton4.Name = "ucMiniButton4";
            this.ucMiniButton4.Size = new System.Drawing.Size(60, 60);
            this.ucMiniButton4.TabIndex = 6;
            // 
            // ucMiniButton3
            // 
            this.ucMiniButton3.Bgcolor = System.Drawing.Color.Empty;
            this.ucMiniButton3.Blselected = false;
            this.ucMiniButton3.Hovercolor = System.Drawing.Color.Empty;
            this.ucMiniButton3.Imagesurl = global::WiClass.Properties.Resources.clear;
            this.ucMiniButton3.Itemtext = null;
            this.ucMiniButton3.Location = new System.Drawing.Point(333, 33);
            this.ucMiniButton3.Name = "ucMiniButton3";
            this.ucMiniButton3.Size = new System.Drawing.Size(60, 60);
            this.ucMiniButton3.TabIndex = 5;
            // 
            // ucMiniButton2
            // 
            this.ucMiniButton2.Bgcolor = System.Drawing.Color.Empty;
            this.ucMiniButton2.Blselected = false;
            this.ucMiniButton2.Hovercolor = System.Drawing.Color.Empty;
            this.ucMiniButton2.Imagesurl = global::WiClass.Properties.Resources.eraser;
            this.ucMiniButton2.Itemtext = null;
            this.ucMiniButton2.Location = new System.Drawing.Point(266, 33);
            this.ucMiniButton2.Name = "ucMiniButton2";
            this.ucMiniButton2.Size = new System.Drawing.Size(60, 60);
            this.ucMiniButton2.TabIndex = 4;
            // 
            // ucMiniButton1
            // 
            this.ucMiniButton1.Bgcolor = System.Drawing.Color.Empty;
            this.ucMiniButton1.Blselected = false;
            this.ucMiniButton1.Hovercolor = System.Drawing.Color.Empty;
            this.ucMiniButton1.Imagesurl = global::WiClass.Properties.Resources.pen;
            this.ucMiniButton1.Itemtext = null;
            this.ucMiniButton1.Location = new System.Drawing.Point(199, 33);
            this.ucMiniButton1.Name = "ucMiniButton1";
            this.ucMiniButton1.Size = new System.Drawing.Size(60, 60);
            this.ucMiniButton1.TabIndex = 3;
            // 
            // ucSelect
            // 
            this.ucSelect.Bgcolor = System.Drawing.Color.Empty;
            this.ucSelect.Blselected = false;
            this.ucSelect.Hovercolor = System.Drawing.Color.Empty;
            this.ucSelect.Imagesurl = global::WiClass.Properties.Resources.select;
            this.ucSelect.Itemtext = null;
            this.ucSelect.Location = new System.Drawing.Point(132, 33);
            this.ucSelect.Name = "ucSelect";
            this.ucSelect.Size = new System.Drawing.Size(60, 60);
            this.ucSelect.TabIndex = 2;
            // 
            // frmMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(481, 127);
            this.ControlBox = false;
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.ucMiniButton4);
            this.Controls.Add(this.ucMiniButton3);
            this.Controls.Add(this.ucMiniButton2);
            this.Controls.Add(this.ucMiniButton1);
            this.Controls.Add(this.ucSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMini";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmMini";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMini_Load);
            this.pnLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UControl.ucMiniButton ucSelect;
        private UControl.ucMiniButton ucMiniButton1;
        private UControl.ucMiniButton ucMiniButton2;
        private UControl.ucMiniButton ucMiniButton3;
        private UControl.ucMiniButton ucMiniButton4;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnLogoin;
    }
}