using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//==============================================================
//  作者：Tony
//  时间：2017年11月09日
//  文件名：cpMyMenu.cs
//  版本：Ver1.0.0  
//  说明：ContentMenuStrip自定义组件
//  修改者：***
//  修改说明：***
//  修改日期：**/**/**
//==============================================================
namespace WiClass.Class
{
    public partial class MyMenu : MenuStrip
    {
        public MyMenu()
        {
            InitializeComponent();
            this.Renderer = new clsMyMenuRender();//设置渲染  
        }

        public MyMenu(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.Renderer = new clsMyMenuRender();//设置渲染</span>  
        }
    }
}
