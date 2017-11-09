namespace WiClass.UControl
{
    partial class ucMenuItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.picIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 14);
            this.lblName.TabIndex = 0;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIco
            // 
            this.picIco.Enabled = false;
            this.picIco.Location = new System.Drawing.Point(17, 10);
            this.picIco.Name = "picIco";
            this.picIco.Size = new System.Drawing.Size(32, 32);
            this.picIco.TabIndex = 1;
            this.picIco.TabStop = false;
            // 
            // ucMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.picIco);
            this.Controls.Add(this.lblName);
            this.Name = "ucMenuItem";
            this.Size = new System.Drawing.Size(66, 66);
            this.MouseEnter += new System.EventHandler(this.ucMenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucMenuItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucMenuItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picIco;
    }
}
