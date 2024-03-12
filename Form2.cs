using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public char OpcionSeleccionada { get; private set; }
        public void botonpresionado(object sender, EventArgs e)
        {
            try
            {
                var boton = ((Button)sender);
                OpcionSeleccionada = Convert.ToChar(boton.Tag);
                this.DialogResult = DialogResult.OK; // Establece el resultado del diálogo como OK
                this.Close(); // Cierra el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public char getboton(char opc)
        {
            return opc;
            Close();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}