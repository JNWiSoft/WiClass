using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WiClass
{
   
    public partial class frmMini : Form
    {

        Point frmLocation;//鼠标移动位置变量
        Point mouseLocation;
        bool leftFlag;//标签是否为左键

        public frmMini()
        {
            InitializeComponent();
            init();
           
        }
        public void init()
        {

        }

 


        private void frmMini_Load(object sender, EventArgs e)
        {
            
            
        }

 

 

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                frmLocation = this.Location;
                mouseLocation = Control.MousePosition; 
                leftFlag = true; 
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {

                Point pt = Control.MousePosition;
                int rangeX = mouseLocation.X - pt.X;
                int rangeY = mouseLocation.Y - pt.Y;
                this.Location = new Point(frmLocation.X - rangeX, frmLocation.Y - rangeY);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #region 纯色填充
        private void Draw(Rectangle rectangle, Graphics g, int _radius, Color bcolor)
        {
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.AssumeLinear;
            SolidBrush mybrush = new SolidBrush(bcolor);
            g.FillPath(mybrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 2, _radius));
        }
        #endregion
        #region 绘制圆角
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            return gp;
        }
        #endregion
        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 15, Color.FromArgb(117,117, 117));
            base.OnPaint(e);
        }

        private void pnLogoin_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 10, Color.FromArgb(51, 51, 51));
            base.OnPaint(e);
        }




    }
}
