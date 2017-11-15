namespace WiClass.UControl
{
    partial class ucInterButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlItemBg = new System.Windows.Forms.Panel();
            this.picIco = new System.Windows.Forms.PictureBox();
            this.lblItemtext = new System.Windows.Forms.Label();
            this.pnlItemBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlItemBg
            // 
            this.pnlItemBg.Controls.Add(this.picIco);
            this.pnlItemBg.Enabled = false;
            this.pnlItemBg.Location = new System.Drawing.Point(10, 0);
            this.pnlItemBg.Name = "pnlItemBg";
            this.pnlItemBg.Size = new System.Drawing.Size(45, 45);
            this.pnlItemBg.TabIndex = 0;
            this.pnlItemBg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlItemBg_Paint);
            // 
            // picIco
            // 
            this.picIco.BackColor = System.Drawing.SystemColors.Control;
            this.picIco.Enabled = false;
            this.picIco.Location = new System.Drawing.Point(7, 7);
            this.picIco.Name = "picIco";
            this.picIco.Size = new System.Drawing.Size(30, 30);
            this.picIco.TabIndex = 0;
            this.picIco.TabStop = false;
            // 
            // lblItemtext
            // 
            this.lblItemtext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItemtext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lblItemtext.Location = new System.Drawing.Point(0, 48);
            this.lblItemtext.Name = "lblItemtext";
            this.lblItemtext.Size = new System.Drawing.Size(66, 16);
            this.lblItemtext.TabIndex = 1;
            this.lblItemtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucInterButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemtext);
            this.Controls.Add(this.pnlItemBg);
            this.DoubleBuffered = true;
            this.Name = "ucInterButton";
            this.Size = new System.Drawing.Size(66, 66);
            this.MouseLeave += new System.EventHandler(this.ucInterButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucInterButton_MouseHover);
            this.pnlItemBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlItemBg;
        private System.Windows.Forms.Label lblItemtext;
        private System.Windows.Forms.PictureBox picIco;
    }
}
