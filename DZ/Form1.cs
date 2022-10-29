using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sluchainaya_velichina = new Random(); 
            int kubik = sluchainaya_velichina.Next(1, 200); 
            MessageBox.Show("  Ваше число " + kubik + "?");
        }


    }
}
