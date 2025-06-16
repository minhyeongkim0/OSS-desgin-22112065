using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class OwnerScreen : Form
    {
        public OwnerScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuRegister f2= new MenuRegister();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderReceptionScreen reception=new OrderReceptionScreen();  
            reception.Show();
      
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            PayScreen pay=new PayScreen();
            pay.Show();
        }

        private void SalesbyDateButton(object sender, EventArgs e)
        {
            SalesbyDate list=new SalesbyDate(); 
            list.Show();    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddOwnerCode aoc=new AddOwnerCode();
            aoc.Show();
        }
    }
}
