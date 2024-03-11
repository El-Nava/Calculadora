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

        public void botonpresionado(object sender, EventArgs e)
        {
            try
            {
                char opc;
                var boton = ((Button)sender);
                opc = Convert.ToChar(boton.Tag);
                getboton(opc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public char getboton(char opc)
        {
            return opc;
        }
     }
}