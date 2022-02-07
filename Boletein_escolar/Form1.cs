using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletein_escolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declarando as variaveis

            String nome ,turma,turno, curso;
            double nota1, nota2,media;


            //atribuindo os valores das variaveis

            nome = textBox1.Text;
            turma = textBox2.Text;
            turno = textBox3.Text;
            curso = textBox4.Text;

            //convertendo double
            nota1 = Convert.ToDouble(textBox5.Text);
            nota2  = Convert.ToDouble(textBox6.Text);
            //media
            media = (nota1 + nota2) / 2;
            
            //atribuindo as variaveis a label

            label10.Text = nome +"\n" + turma +"\n" + turno +"\n" +curso;
            label11.Text = Convert.ToString(label11.Text) +media ;

            //situação

            if (media >=6)
            {
                label12.ForeColor = System.Drawing.Color.Green;
                label12.Text = "APROVADO!";
            }
            else
            {
                label12.ForeColor = System.Drawing.Color.Red;
                label12.Text = "REPROVADO!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sair
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
