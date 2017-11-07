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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            init();
        }
        private void init()
        {
            picBackground.Image = Image.FromFile("Background/bg1.png");
        }

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


    }
}
