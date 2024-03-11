using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double Num1 = 0, Num2 = 0, resultado;
        char Operador;
        Menu submenu;
        public Calculadora()
        {
            InitializeComponent();
            submenu = new Menu();
        }
        public void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (TxtResultados.Text == "0")
            {
                TxtResultados.Text = "";
            }
            TxtResultados.Text += boton.Text;
        }

        public void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (TxtResultados.Text.Length > 1)
            {
                TxtResultados.Text = TxtResultados.Text.Substring(0, TxtResultados.Text.Length - 1);
            }
            else
            {
                TxtResultados.Text = "0";
            }
        }

        public void BtnBorrarTodo_Click(object sender, EventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            Operador = '\0';
            TxtResultados.Text = "0";
        }

        public void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxtResultados.Text = "0";
        }

        public void BtnPunto_Click(object sender, EventArgs e)
        {
            if (!TxtResultados.Text.Contains("."))
            {
                TxtResultados.Text += ".";
            }
        }

        public void BtnSigno_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(TxtResultados.Text);
            Num1 *= -1;
            TxtResultados.Text = Num1.ToString();
        }

        private void Btnsubmenu_Click(object sender, EventArgs e)
        {
            submenu.Show();
        }

        public void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                Num2 = Convert.ToDouble(TxtResultados.Text);
                switch (Operador)
                {
                    case '+':
                        TxtResultados.Text = (Num1 + Num2).ToString();
                        resultado = Convert.ToDouble(TxtResultados.Text);
                        break;
                    case '-':
                        TxtResultados.Text = (Num1 - Num2).ToString();
                        resultado = Convert.ToDouble(TxtResultados.Text);
                        break;
                    case '÷':
                        if (Num2 == 0)
                        {
                            MessageBox.Show("Error: No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        TxtResultados.Text = (Num1 / Num2).ToString();
                        resultado = Convert.ToDouble(TxtResultados.Text);
                        break;
                    case 'x':
                        TxtResultados.Text = (Num1 * Num2).ToString();
                        resultado = Convert.ToDouble(TxtResultados.Text);
                        break;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Formato de número no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: División entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex) // Capturar cualquier otro error inesperado
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public char opc;
        public void OperadorClick(object sender, EventArgs e)
        {

            char opcion;
            opcion = submenu.getboton(opc);
            MessageBox.Show(Convert.ToString(opcion));
            var boton = ((Button)sender);
            Num1 = Convert.ToDouble(TxtResultados.Text);
            Operador = Convert.ToChar(boton.Tag);
            switch (Operador)
            {
                case '²':
                    resultado = Math.Pow(Num1, 2);
                    TxtResultados.Text = resultado.ToString();
                    break;
                case '√':
                    resultado = Math.Sqrt(Num1);
                    TxtResultados.Text = resultado.ToString();
                    break;
                default:
                    TxtResultados.Text = "0";
                    break;
            }
            switch (opcion)
            {
                case 'S':
                    resultado = Math.Sin(Num1);
                    TxtResultados.Text = resultado.ToString();
                    break;
                case 'C':
                    resultado = Math.Cos(Num1);
                    TxtResultados.Text = resultado.ToString();
                    break;
                case 'T':
                    resultado = Math.Tan(Num1);
                    TxtResultados.Text = resultado.ToString();
                    break;
            }
        }
    }
}