using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//==============================================================
//  作者：Tony
//  时间：2017年11月08日
//  文件名：ucStartMenuItem.cs
//  版本：Ver1.0.0  
//  说明：开始菜单项用户控件
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.UControl
{
    public partial class ucStartMenuItem : UserControl
    {

        #region 自定义属性
        private bool childitem = false;
        //自定义属性--文字
        public string ItemText
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
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
        public bool ChildItem
        {
            get
            {
                return childitem;
            }
            set
            {
                childitem = value;
            }
        }
        #endregion

        public ucStartMenuItem()
        {
            InitializeComponent();
        }
        #region 初始设置
        /// <summary>
        /// 初始设置
        /// </summary>
        public void init()
        {
            if (!childitem)
            {
                picArrow.Visible = false;
            }
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

    }
}
