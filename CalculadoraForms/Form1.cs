using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0, num2 = 0, sm, dv, mt, sb, rq2, pot, fat, pi, ng, control = 0;
        string op = "";
        private void RESULT_TextChanged(object sender, EventArgs e)
        {
            RESULT.ReadOnly = true;
            if(RESULT.ReadOnly == true)
            {
                this.RESULT.ForeColor = Color.Lime;
            }
        }

        private void ZERO_Click(object sender, EventArgs e)
        {
            RESULT.Text += "0";
        }

        private void UM_Click(object sender, EventArgs e)
        {
            RESULT.Text += "1";
        }
        private void DOIS_Click(object sender, EventArgs e)
        {
            RESULT.Text += "2";
        }
        private void TRES_Click(object sender, EventArgs e)
        {
            RESULT.Text += "3";
        }
        private void QUATRO_Click(object sender, EventArgs e)
        {
            RESULT.Text += "4";
        }
        private void CINCO_Click(object sender, EventArgs e)
        {
            RESULT.Text += "5";
        }
        private void SEIS_Click(object sender, EventArgs e)
        {
            RESULT.Text += "6";
        }
        private void SETE_Click(object sender, EventArgs e)
        {
            RESULT.Text += "7";
        }
        private void OITO_Click(object sender, EventArgs e)
        {
            RESULT.Text += "8";
        }
        private void NOVE_Click(object sender, EventArgs e)
        {
            RESULT.Text += "9";
        }
        private void PONTO_Click(object sender, EventArgs e)
        {
            RESULT.Text += ".";
        }
        private void PI_Click(object sender, EventArgs e)
        {
            RESULT.Text = $"{Math.PI:F4}";
            pi = Convert.ToDouble(RESULT.Text);
        }
        private void LIMPARNUM_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                RESULT.Text = "";
            }
        }
        private void LIMPAR_Click(object sender, EventArgs e)
        {
            RESULT.Clear();
            label1.Text = "";
        }
        private void MAIS_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                op = "SOMA";
                label1.Text = $"{num1} + ";
                
            }
            
        }
        private void MENOS_Click(object sender, EventArgs e)
        {
            if (RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                op = "MENOS";
                label1.Text = $"{num1} - ";
            }
        }
        private void VEZES_Click(object sender, EventArgs e)
        {
           if(RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                op = "VEZES";
                label1.Text = $"{num1} x ";
            }
           
        }
        private void DIVISAO_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                op = "DIVISAO";
                label1.Text = $"{num1} ÷ ";
            }
        }
        private void FATORIAL_Click(object sender, EventArgs e)
        {

            if(RESULT.Text != "")
            {
                num1 = Convert.ToInt32(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                int fatorial = (int)num1;
                for (int i = (int)num1 - 1; i >= 1; i--)
                {
                    fatorial *= i;
                }
                label1.Text = Convert.ToString(fatorial);
                label1.Text = $"{num1}! = {fatorial}";
                fat = fatorial;
                RESULT.Text = Convert.ToString(fat);
            }
        }
        private void RAIZQ_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                rq2 = Math.Sqrt(num1);
                label1.Text = Convert.ToString(rq2);
                label1.Text = $"²√{num1} = {rq2}";
                RESULT.Text = Convert.ToString(rq2);
            }
            
        }
        private void ELEVADO_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                RESULT.Text = "";
                pot = Math.Pow(num1, 2);
                label1.Text = Convert.ToString(pot);
                label1.Text = $"{num1}² = {pot}";
                RESULT.Text = Convert.ToString(pot);
            }
        }
        private void IGUAL_Click(object sender, EventArgs e)
        {
            if(RESULT.Text != "")
            {
                
                if (labelOP.Text == "MAIS")
                    op = "SOMA";
                else if (labelOP.Text == "MENOS")
                    op = "MENOS";
                else if (labelOP.Text == "VEZES")
                    op = "VEZES";
                else if (labelOP.Text == "DIVISAO")
                    op = "DIVISAO";
               if (control == 0)
                {
                    num2 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                    control = 1;
                }
                else
                    num1 = Convert.ToDouble(RESULT.Text, CultureInfo.InvariantCulture);
                switch (op)
                {
                    case "SOMA":
                        sm = num1 + num2;
                        label1.Text = $"{num1} + {num2} = {sm}";
                        RESULT.Text = Convert.ToString(sm);
                        break;
                    case "MENOS":
                        sb = num1 - num2;
                        label1.Text = $"{num1} - {num2} = {sb}";
                        RESULT.Text = Convert.ToString(sb);
                        break;
                    case "VEZES":
                        mt = num1 * num2;
                        label1.Text = $"{num1} x {num2} = {mt}";
                        RESULT.Text = Convert.ToString(mt);
                        break;
                    case "DIVISAO":
                        dv = num1 / num2;
                        label1.Text = $"{num1} ÷ {num2} = {dv}";
                        RESULT.Text = Convert.ToString(dv);
                        break;
                }
            }
        }
    }
}   