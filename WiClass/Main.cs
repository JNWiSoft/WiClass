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
        private int ibtselect = 0;//互动操作按钮选中状态0：全部未选中，1：书写，2：选择，3测试
        
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
    }
}
