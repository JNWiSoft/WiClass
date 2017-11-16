namespace WiClass.UControl
{
    partial class ucStudentList
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
            this.pnlStuListTit = new System.Windows.Forms.Panel();
            this.lblStulistTit = new System.Windows.Forms.Label();
            this.picAllStu = new System.Windows.Forms.PictureBox();
            this.pnlStuListTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAllStu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStuListTit
            // 
            this.pnlStuListTit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStuListTit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlStuListTit.Controls.Add(this.picAllStu);
            this.pnlStuListTit.Controls.Add(this.lblStulistTit);
            this.pnlStuListTit.Location = new System.Drawing.Point(0, 0);
            this.pnlStuListTit.Name = "pnlStuListTit";
            this.pnlStuListTit.Size = new System.Drawing.Size(375, 50);
            this.pnlStuListTit.TabIndex = 1;
            // 
            // lblStulistTit
            // 
            this.lblStulistTit.AutoSize = true;
            this.lblStulistTit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStulistTit.Location = new System.Drawing.Point(13, 13);
            this.lblStulistTit.Name = "lblStulistTit";
            this.lblStulistTit.Size = new System.Drawing.Size(65, 20);
            this.lblStulistTit.TabIndex = 0;
            this.lblStulistTit.Text = "学生列表";
            // 
            // picAllStu
            // 
            this.picAllStu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAllStu.Image = global::WiClass.Properties.Resources.studentAll;
            this.picAllStu.Location = new System.Drawing.Point(334, 13);
            this.picAllStu.Name = "picAllStu";
            this.picAllStu.Size = new System.Drawing.Size(20, 20);
            this.picAllStu.TabIndex = 1;
            this.picAllStu.TabStop = false;
            // 
            // ucStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlStuListTit);
            this.Name = "ucStudentList";
            this.Size = new System.Drawing.Size(375, 570);
            this.pnlStuListTit.ResumeLayout(false);
            this.pnlStuListTit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAllStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStuListTit;
        private System.Windows.Forms.PictureBox picAllStu;
        private System.Windows.Forms.Label lblStulistTit;
    }
}
