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
        public static Form f;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public frmMini()
        {
            InitializeComponent();

        }
       
        private void frmMini_Load(object sender, EventArgs e)
        {
            ucMiniButton1.DrawBg();
            init();
        }

        private void init()
        {
            f = this;
            this.Left = Screen.AllScreens[0].WorkingArea.Width - 500;
            this.Top = Screen.AllScreens[0].WorkingArea.Height - 200;
        }


        private void ucMiniButton1_BackgroundImageChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Created == false)
                    return;
                if (ucMiniButton1.BackgroundImage != null)
                {
                    Bitmap bm = new Bitmap(ucMiniButton1.BackgroundImage);
                    DSAPI.控件.Form窗体.透明窗体样式显示图像(this, bm, 255);
                }
            }
            catch
            {
            }
        }

        private void ucMiniButton1_ItemClick(Class.proMyItem Itm)
        {
            switch (Itm.Itemid)
            {
                case 0:
                    //TODO：鼠标
                    break;
                case 1:
                    //TODO：logo图标事件
                    break;
                case 2:
                    //TODO：画笔图标事件
                    break;
                case 3:
                    //TODO：橡皮图标事件
                    break;
                case 4:
                    //TODO：清除图标事件
                    break;
                case 5:
                    this.Hide();
                    Main.f.Show();
                    break;
                default:
                    break;
            }
        }

        private void ucMiniButton1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


    }
}
