using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//==============================================================
//  作者：Tony
//  时间：2017年11月09日
//  文件名：clsMenuColor.cs
//  版本：Ver1.0.0  
//  说明：菜单颜色属性专用类
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.Class
{
    class clsMenuColor
    {
        public class ColorConfig
        {
            #region 菜单字体颜色  
            private Color _fontcolor = Color.FromArgb(81,81,81);
            /// <summary>  
            /// 菜单字体颜色  
            /// </summary>  
            public Color FontColor
            {
                get { return this._fontcolor; }
                set { this._fontcolor = value; }
            }
            #endregion

            #region 下拉菜单坐标图标区域开始颜色
            private Color _marginstartcolor = Color.FromArgb(215, 215, 215);
            /// <summary>  
            /// 下拉菜单坐标图标区域开始颜色  
            /// </summary>  
            public Color MarginStartColor
            {
                get { return this._marginstartcolor; }
                set { this._marginstartcolor = value; }
            }
            #endregion

            #region 下拉菜单坐标图标区域结束颜色 

            private Color _marginendcolor = Color.FromArgb(228, 228, 228);
            /// <summary>  
            /// 下拉菜单坐标图标区域结束颜色  
            /// </summary>  
            public Color MarginEndColor
            {
                get { return this._marginendcolor; }
                set { this._marginendcolor = value; }
            }
            #endregion

            #region 下拉项背景颜色
            private Color _dropdownitembackcolor = Color.FromArgb(242, 242, 242);
            /// <summary>  
            /// 下拉项背景颜色  
            /// </summary>  
            public Color DropDownItemBackColor
            {
                get { return this._dropdownitembackcolor; }
                set { this._dropdownitembackcolor = value; }
            }
            #endregion

            #region 下拉项选中时开始颜色
            private Color _dropdownitemstartcolor = Color.FromArgb(228,228,228);
            /// <summary>  
            /// 下拉项选中时开始颜色  
            /// </summary>  
            public Color DropDownItemStartColor
            {
                get { return this._dropdownitemstartcolor; }
                set { this._dropdownitemstartcolor = value; }
            }
            #endregion

            #region  下拉项选中时结束颜色
            private Color _dorpdownitemendcolor = Color.FromArgb(228,228,228);
            /// <summary>  
            /// 下拉项选中时结束颜色  
            /// </summary>  
            public Color DropDownItemEndColor
            {
                get { return this._dorpdownitemendcolor; }
                set { this._dorpdownitemendcolor = value; }
            }
            #endregion

            #region 主菜单项选中时的开始颜色
            private Color _menuitemstartcolor = Color.FromArgb(52, 106, 159);
            /// <summary>  
            /// 主菜单项选中时的开始颜色  
            /// </summary>  
            public Color MenuItemStartColor
            {
                get { return this._menuitemstartcolor; }
                set { this._menuitemstartcolor = value; }
            }
            #endregion

            #region 主菜单项选中时的结束颜色
            private Color _menuitemendcolor = Color.FromArgb(73, 124, 174);
            /// <summary>  
            /// 主菜单项选中时的结束颜色  
            /// </summary>  
            public Color MenuItemEndColor
            {
                get { return this._menuitemendcolor; }
                set { this._menuitemendcolor = value; }
            }
            #endregion

            #region 分割线颜色  
            private Color _separatorcolor = Color.Gray;
            /// <summary>  
            /// 分割线颜色  
            /// </summary>  
            public Color SeparatorColor
            {
                get { return this._separatorcolor; }
                set { this._separatorcolor = value; }
            }
            #endregion

            #region 主菜单背景色  
            private Color _mainmenubackcolor = Color.FromArgb(242, 242, 242);
            /// <summary>  
            /// 主菜单背景色  
            /// </summary>  
            public Color MainMenuBackColor
            {
                get { return this._mainmenubackcolor; }
                set { this._mainmenubackcolor = value; }
            }
            #endregion

            #region 主菜单背景开始颜色
            private Color _mainmenustartcolor = Color.FromArgb(242, 242, 242);
            /// <summary>  
            /// 主菜单背景开始颜色  
            /// </summary>  
            public Color MainMenuStartColor
            {
                get { return this._mainmenustartcolor; }
                set { this._mainmenustartcolor = value; }
            }
            #endregion

            #region 主菜单背景结束颜色
            private Color _mainmenuendcolor = Color.FromArgb(242, 242, 242);
            /// <summary>  
            /// 主菜单背景结束颜色  
            /// </summary>  
            public Color MainMenuEndColor
            {
                get { return this._mainmenuendcolor; }
                set { this._mainmenuendcolor = value; }
            }
            #endregion

            #region 下拉区域边框颜色
            private Color _dropdownborder = Color.FromArgb(215, 215, 215);
            /// <summary>  
            /// 下拉区域边框颜色  
            /// </summary>  
            public Color DropDownBorder
            {
                get { return this._dropdownborder; }
                set { this._dropdownborder = value; }
            }
            #endregion
        }
    }
}
