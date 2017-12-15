using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiClass.Class
{
    
    [TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public class proMyItem
    {
        //图标
        private Image icoimg = null;
        //填充颜色
        private Color fillcolor;
        //边框颜色
        private Color bodercolor;
        //边框宽度
        private int boderwidth;
        //圆角大小
        private int rudius;
        //宽
        private int bwidth;
        //高
        private int bheight;
        //图标宽
        private int imgwidth;
        //图标高
        private int imgheight;
        //区域
        private Region itemregion;
        //鼠标进入
        private bool MouseEnter = false;
        //图标ID
        private int itemid;

        public Image Icoimg
        {
            get
            {
                return icoimg;
            }

            set
            {
                icoimg = value;
            }
        }

        public Color Fillcolor
        {
            get
            {
                return fillcolor;
            }

            set
            {
                fillcolor = value;
            }
        }

        public Color Bodercolor
        {
            get
            {
                return bodercolor;
            }

            set
            {
                bodercolor = value;
            }
        }

        public int Boderwidth
        {
            get
            {
                return boderwidth;
            }

            set
            {
                boderwidth = value;
            }
        }

        public int Rudius
        {
            get
            {
                return rudius;
            }

            set
            {
                rudius = value;
            }
        }

        public int Bwidth
        {
            get
            {
                return bwidth;
            }

            set
            {
                bwidth = value;
            }
        }

        public int Bheight
        {
            get
            {
                return bheight;
            }

            set
            {
                bheight = value;
            }
        }

        public int Imgwidth
        {
            get
            {
                return imgwidth;
            }

            set
            {
                imgwidth = value;
            }
        }

        public int Imgheight
        {
            get
            {
                return imgheight;
            }

            set
            {
                imgheight = value;
            }
        }
        [Browsable(false)]
        public Region Itemregion
        {
            get
            {
                return itemregion;
            }

            set
            {
                itemregion = value;
            }
        }
        [Browsable(false)]
        public bool MouseEnter1
        {
            get
            {
                return MouseEnter;
            }

            set
            {
                MouseEnter = value;
            }
        }
        [Browsable(false)]
        public int Itemid
        {
            get
            {
                return itemid;
            }

            set
            {
                itemid = value;
            }
        }
    }
}
