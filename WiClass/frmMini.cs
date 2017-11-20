using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiClass
{
    public partial class frmMini : Form
    {
        public frmMini()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            this.TransparencyKey = this.BackColor;
            
        }
    }
}
