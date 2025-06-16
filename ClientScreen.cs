using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class ClientScreen : Form
    {
        public ClientScreen()
        {
            InitializeComponent();
        }

        private void ViewTopMenuButton(object sender, EventArgs e)
        {
            ViewTopMenu vtm = new ViewTopMenu();
            vtm.Show(); 
        }

        private void OrderButton(object sender, EventArgs e)
        {
            Order f3 = new Order();
            f3.Show();
        }

        private void SelectTopMenuButton(object sender, EventArgs e)
        {
            SelectTopMenu stm = new SelectTopMenu();
            stm.Show();
        }
    }
}
