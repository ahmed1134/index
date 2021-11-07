using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index_hesaplama_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(textBox1.Text);
            double boy = Convert.ToDouble(textBox2.Text);
            double işlem = kilo / (boy * boy);
            if (işlem > 30)
            {
                MessageBox.Show("İdeal kilonun çok uzerinde:)...");

            }
            else if (işlem >= 25 && işlem <30)
            {
                MessageBox.Show("İdeal kilonun Üzerinde:)...");

            }
            else if (işlem>= 18.5 && işlem < 25)
            {
                MessageBox.Show("İdeal kilo:)...");
            }
            else
            {
                MessageBox.Show("İdeal kilonun altında:)...");
            }
        }
    }
}
