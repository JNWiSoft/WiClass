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
    }
}
