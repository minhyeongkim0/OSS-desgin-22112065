﻿using System;
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
    public partial class ModeChoiceScreen : Form
    {
        public ModeChoiceScreen()
        {
            InitializeComponent();
        }

        private void OwnerButton(object sender, EventArgs e)
        {
            Login Ol=new Login();
            Ol.Show();
        }

        private void ClientButton(object sender, EventArgs e)
        {
          ClientScreen cs=new ClientScreen();
            cs.Show();  
        }
    }
}
