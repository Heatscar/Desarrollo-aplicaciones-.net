using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace tablas_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.MaxLength = 2;
            textBox2.MaxLength = 5;                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int tabla = int.Parse(textBox1.Text);
                int limite = int.Parse(textBox2.Text);
                int resultado;

                for (int i = 1; i <= limite; i++)
                {
                    resultado = tabla * i;
                    listBox1.Items.Add(tabla + "x" + i + "=" + resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los campos esta vacio");                
            }
           
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Select();
        }
    }
}
