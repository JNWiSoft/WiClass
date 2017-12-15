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
using WiClass.Class;
//==============================================================
//  作者：Tony
//  时间：2017年12月15日
//  文件名：ucMiniButton.cs
//  版本：Ver1.0.0  
//  说明：Mini菜单用户控件绘制
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.UControl
{

    public partial class ucMiniButton : UserControl
    {
        //定义点击事件
        public event ItemClickEventHandler ItemClick;
        public delegate void ItemClickEventHandler(proMyItem Itm);

        private Bitmap _ShadowLayer = null; //阴影层
        private Bitmap B = null;
        #region 自定义属性

        public List<proMyItem> items = new List<proMyItem>();//Item属性

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<proMyItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }

        #endregion
        public ucMiniButton()
        {
            InitializeComponent();
        }

        #region 绘制所有Button
        /// <summary>
        /// 绘制所有button背景
        /// </summary>
        public void DrawItem()
        {
            _ShadowLayer = null;
            _ShadowLayer = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(_ShadowLayer);
            g.Clip = new Region(new Rectangle(0, 0, this.Width, this.Height));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //g.SmoothingMode = SmoothingMode.HighQuality;
            int XX = 10;
            int YY = 0;

            for (int i = 0; i <= items.Count - 1; i++)
            {
                YY = this.Height / 2 - items[i].Bheight / 2;
                Point pt = new Point(XX, YY);
                Size sz = new Size(items[i].Bwidth, items[i].Bheight);
                DrawButton(pt, sz, items[i].Boderwidth, items[i].Fillcolor, items[i].Bodercolor, items[i].Rudius, items[i].Icoimg, items[i].Imgwidth, items[i].Imgheight, g);
                XX += items[i].Bwidth + 10;
                items[i].Itemregion = g.Clip;
                items[i].Itemid = i;
            }
            DSAPI.图形图像.挖空投影(ref _ShadowLayer, 5, 30);
        }
        #endregion

        #region 绘制背景方法
        /// <summary>
        /// 作为背景绘制
        /// </summary>
        public void DrawBg()
        {

            if (_ShadowLayer == null)
                DrawItem();

            int _W = 0;
            int _H = 0;
            _W = this.Width;
            _H = this.Height;
            B = null;
            B = new Bitmap(this.Width, this.Height);
            Graphics G = Graphics.FromImage(B);
            G.Clip = new Region(new Rectangle(0, 0, this.Width, this.Height));
            if (_ShadowLayer != null)
            {
                G.DrawImage(_ShadowLayer, new Rectangle(0, 0, this.Width, this.Height), new Rectangle(0, 0, this.Width, this.Height), GraphicsUnit.Pixel);
            }
            this.BackgroundImage = B;
        }
        #endregion

        #region 绘制单个Button
        /// <summary>
        /// 绘制单个Button
        /// </summary>
        /// <param name="pt">起始点</param>
        /// <param name="s">尺寸</param>
        /// <param name="borderwidth">边框宽度</param>
        /// <param name="fillcolor">填充颜色</param>
        /// <param name="bordercolor">边框颜色</param>
        /// <param name="Radius">圆角半径</param>
        /// <param name="img">图标</param>
        /// <param name="imgwidth">图标宽</param>
        /// <param name="imgheight">图标高</param>
        /// <param name="g">图层</param>
        private void DrawButton(Point pt, Size s, int borderwidth, Color fillcolor, Color bordercolor, int Radius, Image img, int imgwidth, int imgheight, Graphics g)
        {
            GraphicsPath Gp = new GraphicsPath();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //绘制图形
            Gp.StartFigure();
            Gp.AddArc(new Rectangle(pt, new Size(Radius, Radius)), 180, 90);
            //Gp.AddLine(new Point(pt.X + Radius, pt.Y), new Point(pt.X + s.Width, pt.Y));
            Gp.AddArc(new Rectangle(new Point(pt.X + s.Width - Radius, pt.Y), new Size(Radius, Radius)), 270, 90);
            //Gp.AddLine(new Point(pt.X + s.Width, pt.Y + Radius), new Point(pt.X + s.Width, pt.Y + s.Height - Radius));
            Gp.AddArc(new Rectangle(new Point(pt.X + s.Width - Radius, pt.Y + s.Height - Radius), new Size(Radius, Radius)), 0, 90);
            //Gp.AddLine(new Point(pt.X + s.Width - Radius, pt.Y + s.Height), new Point(pt.X + Radius, pt.Y + s.Height));
            Gp.AddArc(new Rectangle(new Point(pt.X, pt.Y + s.Height - Radius), new Size(Radius, Radius)), 90, 90);
            Gp.AddLine(new Point(pt.X, pt.Y + s.Height - Radius), new Point(pt.X, pt.Y));
            Gp.CloseFigure();

            //绘制范围：区域宽度和高度都加1，解决右边的下边少一像素问题。问题原因未找到。
            //TODO：需要解决原绘制区域少一像素问题。
            GraphicsPath Gp1 = new GraphicsPath();
            Gp1.StartFigure();
            Gp1.AddArc(new Rectangle(pt, new Size(Radius, Radius)), 180, 90);
            Gp1.AddLine(new Point(pt.X + Radius, pt.Y), new Point(pt.X + s.Width + 1 - Radius, pt.Y));
            Gp1.AddArc(new Rectangle(new Point(pt.X + s.Width + 1 - Radius, pt.Y), new Size(Radius, Radius)), 270, 90);
            Gp1.AddLine(new Point(pt.X + s.Width + 1, pt.Y + Radius / 2), new Point(pt.X + s.Width + 1, pt.Y + s.Height - Radius));
            Gp1.AddArc(new Rectangle(new Point(pt.X + s.Width + 1 - Radius, pt.Y + 1 + s.Height - Radius), new Size(Radius, Radius)), 0, 90);
            Gp1.AddLine(new Point(pt.X + s.Width + 1 - Radius, pt.Y + 1 + s.Height), new Point(pt.X + Radius + 1, pt.Y + 1 + s.Height));
            Gp1.AddArc(new Rectangle(new Point(pt.X, pt.Y + 1 + s.Height - Radius), new Size(Radius, Radius)), 90, 90);
            Gp1.AddLine(new Point(pt.X, pt.Y + s.Height + 1 - Radius), new Point(pt.X, pt.Y + Radius));

            g.Clip = new Region(Gp1);
            g.FillPath(new SolidBrush(fillcolor), Gp);
            g.DrawPath(new Pen(bordercolor, borderwidth), Gp);
            g.DrawImage(img, (s.Width - imgwidth) / 2 + pt.X, (s.Height - imgheight) / 2 + pt.Y, imgwidth, imgheight);
        }
        #endregion

        #region 重写OnMouseClick
        /// <summary>
        /// 重写OnMouseClick
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                proMyItem Itm = GetItemAtPoint(new Point(e.Location.X + this.Location.X, e.Location.Y + this.Location.Y));

                if (Itm != null)
                {

                    ItemClick(Itm);
                }

            }
        }
        #endregion

        #region 获取点击目标Item
        /// <summary>
        /// 获取点击目标Item
        /// </summary>
        /// <param name="Pt"></param>
        /// <returns></returns>
        private proMyItem GetItemAtPoint(Point Pt)
        {
            try
            {
                proMyItem Itm1 = null;
                if (items.Count != 0)
                {
                    foreach (proMyItem Itm in items)
                    {
                        if (Itm.Itemregion.IsVisible(Pt))
                        {
                            Itm1 = Itm;
                            Itm.MouseEnter1 = true;
                        }
                        else
                        {
                            Itm.MouseEnter1 = false;
                        }
                    }
                }
                return Itm1;
            }
            catch
            {
                return null;
            }
        }
        #endregion




    }
}
