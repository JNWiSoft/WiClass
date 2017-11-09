namespace WiClass.UControl
{
    partial class ucStartMenuItem
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
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(39, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // picArrow
            // 
            this.picArrow.BackgroundImage = global::WiClass.Properties.Resources.Arrow;
            this.picArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picArrow.Location = new System.Drawing.Point(153, 14);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(12, 12);
            this.picArrow.TabIndex = 2;
            this.picArrow.TabStop = false;
            // 
            // picIco
            // 
            this.picIco.Enabled = false;
            this.picIco.Location = new System.Drawing.Point(8, 8);
            this.picIco.Name = "picIco";
            this.picIco.Size = new System.Drawing.Size(24, 24);
            this.picIco.TabIndex = 0;
            this.picIco.TabStop = false;
            // 
            // ucStartMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picIco);
            this.Name = "ucStartMenuItem";
            this.Size = new System.Drawing.Size(175, 40);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIco;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picArrow;
    }
}
