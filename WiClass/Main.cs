using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiClass.Class;
using WiClass.UControl;
//==============================================================
//  作者：Tony
//  时间：2017年11月05日
//  文件名：Main.cs
//  版本：Ver1.0.0  
//  说明：主界面窗体
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass
{
    public partial class Main : Form
    {
        private int ibtselect = 0; //互动操作按钮选中状态0：全部未选中，1：书写，2：选择，3测试

        #region 下方工具栏按钮对应的选中状态定义 2017-11-30 高峰
        public const int IS_PEN = 1;
        public const int IS_ERASER = 2;
        private int toolBarState = 0;

        #endregion

        #region 屏幕绘制对应的参数定义  2017-11-30 高峰
        Point startPoint;           //鼠标左键点下时在设备坐标上的坐标
        Point lastPoint;            //画线时记录上一个点 
        //一条线条，记录鼠标按下，移动到抬起的点
        private struct Line
        {
            public PointF beginPoint { get; set; }
            public List<PointF> pointList;
        }
        Line current_line;                           //当前正在绘制的线条
        Graphics g;
        Pen p;
        Bitmap m_bmp;               //picturebox中的图像
        PointF m_bmp_pt;             //m_bmp在picturebox中的起点坐标
        private List<Line> lines = new List<Line>(); //记录当前页面所有的线条
        #endregion

        #region 橡皮擦除功能对应的参数定义 2017-11-30 高峰
        Bitmap cm_bmp; //m_bmp的复制，用于实现橡皮擦除功能
        Graphics rg;
        #endregion


        public Main()
        {
            InitializeComponent();

            init();

        }
        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        private void init()
        {
            picBackground.Image = Image.FromFile("Background/bg1.png");
            cmsStartMenu.Renderer = new clsMyMenuRender();
            m_bmp = new Bitmap(picBackground.Image);
            cm_bmp = new Bitmap(picBackground.Image);
            m_bmp_pt = new PointF(0, 0);
        }
        #endregion

        #region 开始菜单图标交互效果
        private void picStartMenuico_MouseHover(object sender, EventArgs e)
        {
            picStartMenuico.BackColor = Color.FromArgb(255, 53, 53, 53);
        }

        private void picStartMenuico_MouseEnter(object sender, EventArgs e)
        {
            picStartMenuico.BackColor = Color.FromArgb(255, 53, 53, 53);
        }

        private void picStartMenuico_MouseLeave(object sender, EventArgs e)
        {
            picStartMenuico.BackColor = Color.FromArgb(255, 67, 67, 67);
        }
        #endregion

        #region 开始菜单按钮事件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picStartMenuico_Click(object sender, EventArgs e)
        {
            Point pnlPoint = new Point();
            pnlPoint.X = pnlToolsbar.Location.X;
            pnlPoint.Y = pnlToolsbar.Location.Y;
            cmsStartMenu.Show(pnlPoint, ToolStripDropDownDirection.AboveRight);//打开开始菜单
        }
        #endregion

        #region 开始菜单项事件
        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 互动按钮点击事件  2017-11-15 Tony
        //书写按钮
        private void btnWrite_Click(object sender, EventArgs e)
        {
            //恢复其他按钮选中状态
            if (ibtselect != 1)
            {
                btnSelectd();
            }
            if (btnWrite.Blselected)
            {
                btnWrite.Blselected = false;
                btnWrite.pnlIItemBg_Selected();
                ibtselect = 0;
                //TODO 关闭书写状态操作
            }
            else
            {
                btnWrite.Blselected = true;
                btnWrite.pnlIItemBg_Selected();
                ibtselect = 1;
                //TODO 书写状态加载控件
            }
        }
        //选择按钮
        private void btnChoice_Click(object sender, EventArgs e)
        {
            //恢复其他按钮选中状态
            if (ibtselect != 2)
            {
                btnSelectd();
            }
            if (btnChoice.Blselected)
            {
                btnChoice.Blselected = false;
                btnChoice.pnlIItemBg_Selected();
                ibtselect = 0;
                //TODO 关闭书写状态操作
            }
            else
            {
                btnChoice.Blselected = true;
                btnChoice.pnlIItemBg_Selected();
                ibtselect = 2;
                //TODO 书写状态加载控件
            }
        }
        //测试按钮
        private void btnTest_Click(object sender, EventArgs e)
        {
            //恢复其他按钮选中状态
            if (ibtselect != 3)
            {
                btnSelectd();
            }
            if (btnTest.Blselected)
            {
                btnTest.Blselected = false;
                btnTest.pnlIItemBg_Selected();
                ibtselect = 0;
                //TODO 关闭书写状态操作
            }
            else
            {
                btnTest.Blselected = true;
                btnTest.pnlIItemBg_Selected();
                ibtselect = 3;
                //TODO 书写状态加载控件
            }
        }
        #endregion

        #region 按钮选中状态处理 2017-11-15 Tony
        /// <summary>
        /// 按钮选中状态统一处理
        /// </summary>
        private void btnSelectd()
        {

            switch(ibtselect)
             {
                case 0:
                    btnWrite.Blselected = false;
                    btnWrite.pnlIItemBg_Selected();
                    btnChoice.Blselected = false;
                    btnChoice.pnlIItemBg_Selected();
                    btnTest.Blselected = false;
                    btnTest.pnlIItemBg_Selected();
                    break;
                case 1:
                    //TODO 关闭书写按钮当前状态的相关操作
                    btnWrite.Blselected = false;
                    btnWrite.pnlIItemBg_Selected();
                   
                    break;
                case 2:
                    //TODO 关闭选择按钮当前状态的相关操作
                    btnChoice.Blselected = false;
                    btnChoice.pnlIItemBg_Selected();
                   
                    break;
                case 3:
                    //TODO 关闭测试按钮当前状态的相关操作
                    btnTest.Blselected = false;
                    btnTest.pnlIItemBg_Selected();
                    
                    break;

            }
        }

        #endregion

        #region 互动窗口弹出  2017-11-16 Tony
        private void ucInteract_Click(object sender, EventArgs e)
        {
            if(pnlInterPanel.Visible)
            {
                pnlInterPanel.Visible = false;
            }
            else
            {
                pnlInterPanel.Visible = true;
            }
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            //加载默认题目内容控件
            ucItemContent ucic = new ucItemContent();
            pnlInformation.Controls.Add(ucic);
            ucic.Dock = DockStyle.Fill;
            //加载默认学生列表控件
            ucStudentList ucsl = new ucStudentList();
            pnlStudentlist.Controls.Add(ucsl);
            ucsl.Dock = DockStyle.Fill;



        }

        private void ucMini_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMini fr = new frmMini();
            fr.Show();
            fr.WindowState = FormWindowState.Normal;
            fr.ShowInTaskbar = false;
            fr.TopLevel = true;
            fr.TopMost = true;
        }

        #region 点击画笔可以在整个桌面上进行绘制 2017-11-30 高峰
        private void ucPen_Click(object sender, EventArgs e)
        {
            toolBarState = IS_PEN;
        }
        #endregion

        #region 点击橡皮可以对绘制的内容进行擦除 2017-11-30 高峰
        private void ucEraser_MouseClick(object sender, MouseEventArgs e)
        {
            toolBarState = IS_ERASER;
        }
        #endregion

        #region picBackground对应的鼠标点击事件 2017-11-30 高峰
        private void picBackground_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (toolBarState == IS_PEN) // 画笔绘制功能
                {
                    startPoint = e.Location;
                    lastPoint = startPoint;

                    //落笔时新建Line对象，并记录起点
                    Line line = new Line();
                    line.pointList = new List<PointF>();
                    line.beginPoint = e.Location;
                    current_line = line;
                } 
            }
        }
        #endregion

        #region picBackground对应的鼠标移动事件 2017-11-30 高峰
        private void picBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(toolBarState == IS_PEN) // 画笔绘制功能
                {
                    g = Graphics.FromImage(m_bmp);
                    p = new Pen(Color.Cyan, 3);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                    //移动时，实时向当前的线条内加入当前的点
                    current_line.pointList.Add(e.Location);

                    if (e.Location != lastPoint)
                    {
                        g.DrawLine(p, lastPoint, e.Location);

                    }
                    p.Dispose();
                    g.Dispose();

                    lastPoint = e.Location;
                    picBackground.Invalidate();
                }else if(toolBarState == IS_ERASER) // 橡皮擦除功能
                {
                    rg = Graphics.FromImage(m_bmp);
                    rg.DrawImage(cm_bmp, new Rectangle(e.Location.X - 10, e.Location.Y - 10, 20, 20),
                        new Rectangle(e.Location.X - 10, e.Location.Y - 10, 20, 20), GraphicsUnit.Pixel);
                    rg.Dispose();
                    picBackground.Invalidate();
                }
            }
        }
        #endregion

        #region picBackground对应的鼠标抬起事件 2017-11-30 高峰
        private void picBackground_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(toolBarState == IS_PEN) //画笔绘制功能
                {
                    if (current_line.pointList == null)
                    {
                        return;
                    }

                    //结束绘制时，将当前线条加入所有的线条中
                    lines.Add(current_line);
                }
                
            }
        }
        #endregion

        #region picBackground对应的绘制时事件 2017-11-30 高峰
        private void picBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            //在指定位置并且按指定大小绘制指定的Image的指定部分。
            g.DrawImage(m_bmp, m_bmp_pt);
        }
        #endregion

    }
}
