using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationsOnVectors
{
    public partial class Form : System.Windows.Forms.Form
    {
        const string SUM = "Сложение";
        const string SUBTRACTING = "Вычитание";
        const string SCALAR_PRODUCT = "Скалярное произведение";
        const string MULTIPLICATION_BY_A_NUMBER = "Умножение на число";
        const string VECTOR_LENGTH = "Длина вектора";
        const string ANGLE_BETWEEN_VECTORS = "Угол между векторами";
        const string COLLINEARITY = "Коллинеарность двух векторов";

        Vektor a, b;
        public Form()
        {
            InitializeComponent();
        }

        private void operac_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            Bx.Visible = true;
            By.Visible = true;
            if (operac.Text == SUM || operac.Text == SUBTRACTING || operac.Text == VECTOR_LENGTH 
                || operac.Text == ANGLE_BETWEEN_VECTORS || operac.Text == COLLINEARITY 
                || operac.Text == SCALAR_PRODUCT)
            {
                Dan.Visible = false;
                if (operac.Text == SUM)
                {
                    formu.Text = "(a(x)+b(x); a(y)+b(y))";
                    rezult.Text = "";
                }
                else if (operac.Text == SUBTRACTING)
                {
                    formu.Text = "(a(x)-b(x); a(y)-b(y))";
                    rezult.Text = "";
                }
                else if (operac.Text == SCALAR_PRODUCT)
                {
                    formu.Text = "a(x)*b(x)+a(y)*b(y)";
                    rezult.Text = "";
                }
                else if (operac.Text == ANGLE_BETWEEN_VECTORS)
                {
                    formu.Text = "(a(x)*b(x)+a(y)*b(y))/(sqrt(a^2(x)+a^2(y))*sqrt(b^2(x)+b^2(y)))";
                    rezult.Text = "";
                }
                else if (operac.Text == COLLINEARITY)
                {
                    formu.Text = "a(x)/b(x) = a(y)/b(y)";
                    rezult.Text = "";
                }
                else
                {
                    formu.Text = "sqrt(x^2+y^2)";
                    label2.Visible = false;
                    Bx.Visible = false;
                    By.Visible = false;
                    rezult.Text = "";
                }

            }
            if (operac.Text == MULTIPLICATION_BY_A_NUMBER)
            {
                label2.Visible = false;
                Bx.Visible = false;
                By.Visible = false;
                Dan.Visible = true;
                Do.Text = "Число z";
                formu.Text = "(z*x; z*y)";
                rezult.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = new Vektor(Convert.ToInt32(Ax.Text), Convert.ToInt32(Ay.Text));
                if (operac.Text != VECTOR_LENGTH && operac.Text != MULTIPLICATION_BY_A_NUMBER)
                    b = new Vektor(Convert.ToInt32(Bx.Text), Convert.ToInt32(By.Text));
                if (operac.Text == SUM)
                {
                    Vektor c = a + b;
                    rezult.Text = c.ToString();
                }
                if (operac.Text == SUBTRACTING)
                {
                    Vektor c = a - b;
                    rezult.Text = c.ToString();
                }
                if (operac.Text == MULTIPLICATION_BY_A_NUMBER)
                {
                    int z = int.Parse(Znach.Text);
                    Vektor c = a * z;
                    rezult.Text = c.ToString();
                }
                if (operac.Text == VECTOR_LENGTH)
                {
                    rezult.Text = (a.Length()).ToString();
                }
                if (operac.Text == SCALAR_PRODUCT)
                {
                    double n = a*b;
                    rezult.Text = n.ToString();
                }
                if (operac.Text == ANGLE_BETWEEN_VECTORS)
                {
                    double n = a/b;
                    rezult.Text = n.ToString();
                }
                if (operac.Text == COLLINEARITY)
                {
                    
                    rezult.Text = a.X + "/" + b.X + "=" + a.Y + "/" + b.Y + " - " + (a==b);
                }
            }
            catch
            {
                rezult.Text = "Error";
            }

        }


        private void C_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            Ax.Text = "";
            Ay.Text = "";
            Bx.Visible = true; Bx.Text = "";
            By.Visible = true; By.Text = "";
            Dan.Visible = true; Do.Text = ""; Znach.Text = "";
            formu.Text = "";
            rezult.Text = "";
            operac.Text = "Выберите операцию";
        }
    }
}
