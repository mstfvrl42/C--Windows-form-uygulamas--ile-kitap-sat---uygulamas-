using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_indirim_tutar_hesablama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        double toplam= 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int adet;
            double kasa;
           

            adet = Convert.ToInt32(textBox1.Text);
            if (adet>0 && adet<=20)
            {
                kasa = (adet *10)*(0.8);
                label4.Text = kasa.ToString()+"TL";
                toplam = toplam + kasa;
                label3.Text = toplam.ToString() +"TL";


            }
            else if(adet>=21 && adet <= 40)
            {
                kasa = (adet * 10) * (0.6);
                label4.Text = kasa.ToString()+"TL";
                toplam = toplam + kasa;
                label3.Text = toplam.ToString() + "TL";

            }
            else if (adet>40)
            {
                kasa = (adet * 10) * (0.5);
                label4.Text = kasa.ToString()+"TL";
                toplam = toplam + kasa;
                label3.Text = toplam.ToString() + "TL";
            }
            else
            {
                MessageBox.Show("Girilen adet hesaplanamadi.");
            }
        }
    }
}
