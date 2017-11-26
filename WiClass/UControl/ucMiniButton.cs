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
using System.Drawing.Text;

namespace WiClass.UControl
{

    public partial class ucMiniButton : UserControl
    {
        #region 自定义属性
        private bool blselected = false;//选中状态
        private Color stacolor;//状态颜色
        private Color bgcolor;//背景颜色
        private Color hovercolor;//hover颜色
        private string itemtext;//文字


        //自定义属性--文字
        public string Itemtext
        {
            get
            {
                return itemtext;
            }

            set
            {
                itemtext = value;
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

        public ucMiniButton()
        {
            InitializeComponent();
            picIco.BackColor = Color.FromArgb(51, 51, 51);
            
        }


        #region 纯色填充
        private void Draw(Rectangle rectangle, Graphics g, int _radius,  Color bcolor)
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
            gp.CloseAllFigures();
            return gp;
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 10,Color.FromArgb(51,51,51));
            base.OnPaint(e);
        }

    }
}
