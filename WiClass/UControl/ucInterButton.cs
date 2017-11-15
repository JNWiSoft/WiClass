using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//==============================================================
//  作者：Tony
//  时间：2017年11月13日
//  文件名：ucInterButton.cs
//  版本：Ver1.0.0  
//  说明：***
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.UControl
{
    public partial class ucInterButton : UserControl
    {



        #region 自定义属性
        private bool blselected = false;//选中状态
        private Color stacolor;//状态颜色
        private Color bgcolor;//背景颜色
        private Color hovercolor;//hover颜色

        
        //自定义属性--文字
        public string Itemtext
        {
            get
            {
                return lblItemtext.Text;
            }

            set
            {
               lblItemtext.Text=value;
            }
        }

        //自定义属性--图标
        public Image Imagesurl
        {
            get
            {
                return picIco.Image;
            }

            set
            {
                picIco.Image = value;
            }
        }
        //自定义属性--背景颜色
        public Color Bgcolor
        {
            get
            {
                return bgcolor;
            }

            set
            {
                bgcolor = value;
                stacolor = value;
            }
        }
        //自定义属性--hover颜色
        public Color Hovercolor
        {
            get
            {
                return hovercolor;
            }

            set
            {
                hovercolor = value;
            }
        }
        //自定义属性--选中状态
        public bool Blselected
        {
            get
            {
                return blselected;
            }

            set
            {
                blselected = value;
            }
        }


        #endregion

        public ucInterButton()
        {
            
            InitializeComponent();
          
            init();

        }

        #region 初始设置
        private void init()
        {
            SetControlEnabled(lblItemtext, false);
            stacolor = bgcolor;
            picIco.BackColor = bgcolor;
        }
        #endregion

        #region 重设Control在Enable状态下的ForeColor值

        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int wndproc);
        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public const int GWL_STYLE = -16;
        public const int WS_DISABLED = 0x8000000;

        /// <summary>
        /// 重设Control在Enable状态下的ForeColor值。
        /// </summary>
        /// 2017/11/07
        /// <param name="c">控件名称</param>
        /// <param name="enabled">状态</param>
        public static void SetControlEnabled(Control c, bool enabled)
        {
            if (enabled)
            { SetWindowLong(c.Handle, GWL_STYLE, (~WS_DISABLED) & GetWindowLong(c.Handle, GWL_STYLE)); }
            else
            { SetWindowLong(c.Handle, GWL_STYLE, WS_DISABLED + GetWindowLong(c.Handle, GWL_STYLE)); }
        }
        #endregion

        #region 纯色填充
        private void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp,Color bcolor)
        {
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
           
            SolidBrush mybrush = new SolidBrush(bcolor);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(mybrush, ptsArray);
            }
            //填充

            g.FillPath(mybrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));
        }
        #endregion

        #region 渐变填充
        //渐变填充
        private void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp, Color begin_color, Color end_color)
        {
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
           
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
           
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));
        }
        #endregion

        #region 重新绘制
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }
        #endregion
         
        #region  pnlItem重绘
        private void pnlItemBg_Paint(object sender, PaintEventArgs e)
        {
            
            Draw(e.ClipRectangle, e.Graphics, 10, false, stacolor);
            picIco.BackColor = stacolor;
            base.OnPaint(e);
        }
        #endregion

        #region 控件状态方法

        //Hover状态
        private void ucInterButton_MouseHover(object sender, EventArgs e)
        {
            if (!blselected)
            {
                stacolor = hovercolor;
                pnlItemBg.Invalidate();

            }
        }
        //Leave状态
        private void ucInterButton_MouseLeave(object sender, EventArgs e)
        {
            if (!blselected)
            {
                stacolor = bgcolor;
                pnlItemBg.Invalidate();
            }
        }
        //选中状态
        public void pnlIItemBg_Selected()
        {
            if (blselected)
            {
                stacolor = hovercolor;
                pnlItemBg.Invalidate();
            }
            else
            {
                stacolor = bgcolor;
                pnlItemBg.Invalidate();
            }
        }
        #endregion


    }
}
