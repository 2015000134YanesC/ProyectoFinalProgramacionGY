namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        double b, c, d, f, g;

        private void DosVariables()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox4.Enabled = false;
            button1.Visible = true;
        }
        private void UnaVariable()
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox4.Enabled = false;
            button1.Visible = true;
        }
        private void TresVariables()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox4.Enabled = false;
            button1.Visible = true;
        }
        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void conocerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 14;
            label1.Text = "Condensador 1:";          
            label2.Text = "Condensador 2:";
            DosVariables();
            Limpiar();
        }

        private void conocerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a = 17;
            label1.Text = "Velocidad";
            label2.Text = "Tiempo";
            DosVariables();
            Limpiar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioDeUnCírculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 1;
            UnaVariable();
            label1.Text = " Perimetro de la circunferencia:";
            
            Limpiar();
        }

        private void conocerLaHipotenusaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 2;
            DosVariables();
            label1.Text = "Opuesto:";
            label2.Text = "Adyacente:";

            Limpiar();
        }

        private void conocerElOpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 3;
            DosVariables();
            label1.Text = "Hipotenusa:";
            label2.Text = "Adyacente:";
            
            Limpiar();
        }

        private void conocerElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 4;
            DosVariables();
            label1.Text = "Hipotenusa:";
            label2.Text = "Opuesto:";
            
            Limpiar();
        }

        private void conocerAlfaConBetaYGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 5;
            DosVariables();
            label1.Text = "Beta:";
            label2.Text = "Gamma:";
            
            Limpiar();
        }

        private void conocerBetaConAlfaYGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 6;
            DosVariables();
            label1.Text = "Alfa";
            label2.Text = "Gamma";
            
            Limpiar();
        }

        private void conocerGammaConAlfaYBe5taToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 7;
            DosVariables();
            label1.Text = "Alfa";
            label2.Text = "Beta";
            
            Limpiar();
        }

        private void conocerLaHipotenusaConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 8;
            DosVariables();
            label1.Text = "Voltaje";
            label2.Text = "Resistencia";
            
            Limpiar();
        }

        private void conocerElOpuestoConBetaGammaYElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 9;
            DosVariables();
            label1.Text = "Corriente";
            label2.Text = "Resistencia";
            
            Limpiar();
        }

        private void conocerElAdyacenteConAlfaGammaYElOpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 10;
            DosVariables();
            label1.Text = "Corriente";
            label2.Text = "Voltaje";
            
            Limpiar();
        }

        private void conocerGammaConAlfaElOpuestoYLaHipotenusaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 11;
            DosVariables();
            label1.Text = "Resistor 1";
            label2.Text = "Resistor 2";
            
            Limpiar();
        }

        private void conocerAlfaConGamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 12;
            DosVariables();
            label1.Text = "Resistor 1";
            label2.Text = "Resistor 2";
            
            Limpiar();
        }

        private void conocerBetaConGammaLaHipotenusaYElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 13;
            DosVariables();
            label1.Text = "Condensador 1";
            label2.Text = "Condensador 2";
            
            Limpiar();
        }

        private void conocerLaVelocidadConDistanciaYTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 15;
            DosVariables();
            label1.Text = "Distancia";
            label2.Text = "Tiempo";
            
            Limpiar();
        }

        private void conocerElTiempoConDistanciaYLaVelocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 16;
            DosVariables();
            label1.Text = "Distancia";
            label2.Text = "Velocidad";
            
            Limpiar();
        }

        private void conocerElVolumenConDensidadYMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 18;
            DosVariables();
            label1.Text = "Densidad";
            label2.Text = "Masa";
            
            Limpiar();
        }

        private void conocerLaMasaConVolumenYDensidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 19;
            DosVariables();
            label1.Text = "Volumen";
            label2.Text = "Densidad";
            
            Limpiar();
        }

        private void múltiplosYPrefijosDeUnidadesMétricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 20;
            DosVariables();
            label1.Text = "Masa";
            label2.Text = "Volumen";
            
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox1.Text);
            if (a == 1)
            {
                c = (b) / (2 * Math.PI);
                textBox4.Text = "" + c;
            }
            if (a == 2)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) + (c * c));
                textBox4.Text = "" + d;
            }
            if (a == 3)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) - (c * c));
                textBox4.Text = "" + d;
            }
            if (a == 4)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) - (c * c));
                textBox4.Text = "" + d;
            }
            if (a == 5)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if (a == 6)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if (a == 7)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if (a == 8)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 9)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 10)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = c / b;
                textBox4.Text = "" + d;
            }
            if (a == 11)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b + c;
                textBox4.Text = "" + d;
            }
            if (a == 12)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = 1 / ((1 / b) + (1 / c));
                textBox4.Text = "" + d;
            }
            if (a == 13)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = 1 / ((1 / b) + (1 / c));
                textBox4.Text = "" + d;
            }
            if (a == 14)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b + c;
                textBox4.Text = "" + d;
            }
            if (a == 15)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 16)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 17)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 18)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 19)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 20)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }
    }
}
