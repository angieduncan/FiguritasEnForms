using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public partial class Calculator : Form
    {
        Double area=0;
        Double perimetro=0;
        String figura = "";
        Double dato1=0;
        Double dato2=0;
        Double dato3=0;
        public Calculator()
        {
            InitializeComponent();
            Square.Checked = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_Dato1.Text = "";
            textBox_Dato2.Text = "";
            textBox_Dato3.Text = "";
            tbxArea.Text = "";
            tbxPerimetro.Text = "";
            
        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Rectangle";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Side(cm)";
            this.label_Dato2.Text = "Height (cm)";
            this.label_Dato3.Text = "";
        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {
            
            figura = "Triangle";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Base(cm)";
            this.label_Dato2.Text = "Height (cm)";
            this.label_Dato3.Text = "";

        }

        private void Diamond_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Diamond";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Major diagonal(cm)";
            this.label_Dato2.Text = "Minor diagonal(cm)";
            //this.label_Dato3.Text = "Side(cm)";


        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Square";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Side(cm)";
            this.label_Dato2.Text = "";
            this.label_Dato3.Text = "";

        }

        private void Rhomboid_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Rhomboid";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Base(cm)";
            this.label_Dato2.Text = "Height (cm)";
            this.label_Dato3.Text = "";

        }

        private void Trapeze_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Trapeze";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.textBox_Dato3.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Height(cm)";
            this.label_Dato2.Text = "Major base(cm)";
            this.label_Dato3.Text = "Minor base(cm)";


        }

        private void radioButton1_CheckedCahnged(object sender, EventArgs e)
        {
            figura = "Circle";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Radio(cm)";
            this.label_Dato2.Text = "";
            this.label_Dato3.Text = "";
        }



        private void Polygon_CheckedChanged(object sender, EventArgs e)
        {
            figura = "Polygon";
            this.textBox_Dato1.BackColor = System.Drawing.Color.White;
            this.textBox_Dato2.BackColor = System.Drawing.Color.White;
            this.textBox_Dato3.BackColor = System.Drawing.Color.White;
            this.Label_Dato1.Text = "Side(cm)";
            this.label_Dato2.Text = "Number of sides";
            this.label_Dato3.Text = "Apothem(cm)";


        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            bool number10k = double.TryParse(textBox_Dato1.Text, out dato1);
            bool number20k = double.TryParse(textBox_Dato1.Text, out dato2);
            bool number30k = double.TryParse(textBox_Dato1.Text, out dato3);

            if (number10k && number20k && number30k) {
                switch (figura)
                {
                    case "Square":
                        area = dato1 * dato1;
                        perimetro = dato1 + dato1 + dato1 + dato1;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Rectangle":
                        area = dato1 * dato2;
                        perimetro = dato1 + dato1 + dato2 + dato2;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Triangle":
                        dato3 = Math.Sqrt(Math.Pow(dato1, 2) + Math.Pow(dato2, 2));
                        area = (dato1 * dato2)/2;
                        perimetro = dato3 + dato3 + dato3 ;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Diamond":
                        area = dato1 * dato2;
                        perimetro = dato3 + dato3 + dato3+ dato3;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Rhomboid":
                        area = dato1 * dato2;
                        perimetro = dato1 + dato1 + dato2 + dato2;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Trapeze":
                        double lado = 0;
                        lado = Math.Sqrt(Math.Pow(((dato1-dato2)/2),2)+Math.Pow((dato1),2));
                        area = dato3*(dato1 * dato2)/2;
                        perimetro = dato2 + dato3 + lado + lado;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Circle":
                        area = dato1 * Math.Pow(Math.PI,2);
                        perimetro = (dato1*2)*Math.PI;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;
                    case "Polygon":
                        area = (dato1*dato3)/2;
                        perimetro = dato1*dato2;
                        tbxArea.Text = area.ToString();
                        tbxPerimetro.Text = perimetro.ToString();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Sowwy, invalid data ಡ ﹏ ಡ ", "Ouchis!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label_Side_Click(object sender, EventArgs e)
        {

        }

        
    }
}
