using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpin.Text += "1";  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtpin.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtpin.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpin.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtpin.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtpin.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpin.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtpin.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtpin.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtpin.Text += "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            String lastChar = txtpin.Text.Substring(0,txtpin.Text.Length - 1);  
            txtpin.Text = lastChar; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string contraseña = Properties.Settings.Default.Contraseña;
            if (txtpin.Text == contraseña)  
            {
                tab1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, verifique y intente nuevamente");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(2); 
              lblBalance.Text = Properties.Settings.Default.Monto;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tab1.SelectTab(0);

        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            WithDraw(2000);    
        }

            private void WithDraw(Double cantidad)
                {
                    double balance = double.Parse(rfa.Text);  

                if (balance >= cantidad)
                {

                    double y = balance - cantidad;
                    Properties.Settings.Default.Monto = Convert.ToString(y);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Retiro completado se ha descontado un % de su balance");
                }

                else
                {
                    MessageBox.Show("No cuenta con suficiente saldo para hacer este retiro, pruebe con otra cantidad");
                }
            }

            private void btn1000_Click(object sender, EventArgs e)
            {
                WithDraw(1000);
            }

            private void btn500_Click(object sender, EventArgs e)
            {
                WithDraw(500);
            }

            private void btn200_Click(object sender, EventArgs e)
            {
                WithDraw(200);
            }

            private void btn100_Click(object sender, EventArgs e)
            {
                WithDraw(100);
            }

            private void button13_Click(object sender, EventArgs e)
            {
                string request = Microsoft.VisualBasic.Interaction.InputBox("Ingrese otra cantidad por favor");
                double efectivo = double.Parse(request);
                MessageBox.Show("" + efectivo);
                WithDraw(efectivo);

            }

            private void btnRetiro_Click(object sender, EventArgs e)
            {
                tab1.SelectTab(3);
                rfa.Text = Properties.Settings.Default.Monto; 
            }
    }
}
