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
//  时间：2017年11月07日 12:18
//  文件名：ucMenuItem.cs
//  版本：Ver1.0.0  
//  说明：功能菜单项用户控件
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.UControl
{
    public partial class ucMenuItem : UserControl
    {
        #region 自定义属性
        private Color bgcolor= Color.FromArgb(255, 67, 67, 67);
        private Color entercolor = Color.FromArgb(255, 53, 53, 53);
        private Color hovercolor = Color.FromArgb(255, 53, 53, 53);
        private Color leavecolor=Color.FromArgb(255, 67, 67, 67);
        
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
        //自定义属性--背景色
        public Color Bgcolor
        {
            get
            {
                return bgcolor;
            }

            set
            {
                bgcolor = value;
            }
        }
        //自定义属性--进入色
        public Color Entercolor
        {
            get
            {
                return entercolor;
            }

            set
            {
                entercolor = value;
            }
        }
        //自定义属性--Hover色
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
        //自定义属性--Leave色
        public Color Leavecolor
        {
            get
            {
                return leavecolor;
            }

            set
            {
                leavecolor = value;
            }
        }

        #endregion
        public ucMenuItem()
        {
            InitializeComponent();
            SetControlEnabled(lblName, false);
            init();
        }
        public void init()
        {
            this.BackColor = Bgcolor;
        }

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
        #region 按钮背景交互状态事件
        private void ucMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = hovercolor;
        }

        private void ucMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = entercolor;
        }

        private void ucMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = leavecolor;
        }
        #endregion
    }
}
