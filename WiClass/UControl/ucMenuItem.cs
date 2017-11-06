using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiClass.UControl
{
    public partial class ucMenuItem : UserControl
    {
        public string ucname;
        public string ItemText
        {
            get {return lblName.Text;}
            set {lblName.Text = value;}
        }
        public Image Imagesurl
        {
            get { return picIco.Image; }
            set { picIco.Image = value; }
        }
   

        public ucMenuItem()
        {
            InitializeComponent();

        }

 


    }
}
