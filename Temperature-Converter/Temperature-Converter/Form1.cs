using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zabezpiecznzie brak przed pomyleiem rzcinak i litermai zamiast cyfr, zaokraglanie wyniku do 2 miejsc
            if (comboBox1.SelectedItem != null && textBox1.Text != "" && textBox1.Text != "")
            {
                double s_kel, s_fakre, s_cel, dane;
                dane = Convert.ToDouble(textBox1.Text);

                if(comboBox1.SelectedItem == "skala Celsjusza")
                {
                    s_cel = dane;
                    s_fakre = 32 + 1.8*s_cel;
                    s_kel = s_cel+273.15;
                    label5.Text = Convert.ToString(s_cel);
                    label6.Text = Convert.ToString(s_fakre);
                    label7.Text = Convert.ToString(s_kel);
                    
                }
                else if(comboBox1.SelectedItem == "skala Fahrenheita")
                {
                    s_cel = (dane - 32) /1.8;
                    s_fakre = dane;
                    s_kel = s_cel + 273.15;
                    label5.Text = Convert.ToString(s_cel);
                    label6.Text = Convert.ToString(s_fakre);
                    label7.Text = Convert.ToString(s_kel);
                }
                else
                {
                    s_cel = dane - 273.15;
                    s_fakre = 32 + 1.8 * s_cel;
                    s_kel = dane;
                    label5.Text = Convert.ToString(s_cel);
                    label6.Text = Convert.ToString(s_fakre);
                    label7.Text = Convert.ToString(s_kel);
                }


            }
            else {
                label5.Text = "Error";
                label6.Text = "Error";
                label7.Text = "Error";
            }
        }
    }
}
