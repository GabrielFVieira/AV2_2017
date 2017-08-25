using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Dano_RPG
{
    public partial class Form1 : Form
    {
        public int dano;
        public int ataque;
        public int defesa;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out ataque);

            if (ataque < 0)
            {
                ataque = 0;
                textBox1.Text = ataque.ToString();
            }

            if (ataque > 100)
            {
                ataque = 100;
                textBox1.Text = ataque.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out ataque);

            if (ataque < 0)
            {
                ataque = 0;
                textBox1.Text = ataque.ToString();
            }

            if (ataque > 100)
            {
                ataque = 100;
                textBox1.Text = ataque.ToString();
            }

            int.TryParse(textBox2.Text, out defesa);

            if (defesa < 0)
                defesa = 0;

            if (defesa > 100)
                defesa = 100;

            if (comboBox1.Text == "Gelo" && comboBox2.Text == "Eletricidade" || comboBox1.Text == "Fogo" && comboBox2.Text == "Gelo" || comboBox1.Text == "Eletricidade" && comboBox2.Text == "Fogo")
            {
                ataque = 2 * ataque;
            }

            else if (comboBox1.Text == "Gelo" && comboBox2.Text == "Fogo" || comboBox1.Text == "Fogo" && comboBox2.Text == "Eletricidade" || comboBox1.Text == "Eletricidade" && comboBox2.Text == "Gelo")
            {
                defesa = 2 * defesa;
            }

            dano = ataque - defesa;

            if (dano < 0)
                dano = 0;

            label3.Text = dano.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             int.TryParse(textBox2.Text, out defesa);

            if (defesa < 0)
            {
                defesa = 0;
                textBox2.Text = defesa.ToString();
            }

            if (defesa > 100)
            {
                defesa = 100;
                textBox2.Text = defesa.ToString();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Gelo")
            {
                comboBox1.BackColor = Color.LightBlue;
            }

            if (comboBox1.Text == "Fogo")
            {
                comboBox1.BackColor = Color.Red;
            }

            if (comboBox1.Text == "Eletricidade")
            {
                comboBox1.BackColor = Color.Yellow;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Gelo")
            {
                comboBox2.BackColor = Color.LightBlue;
            }

            if (comboBox2.Text == "Fogo")
            {
                comboBox2.BackColor = Color.Red;
            }

            if (comboBox2.Text == "Eletricidade")
            {
                comboBox2.BackColor = Color.Yellow;
            }
        }
    }
}
