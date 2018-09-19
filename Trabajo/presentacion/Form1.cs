using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace presentacion
{
    public partial class Form1 : Form
    {
        LogicaEstudiante logEst = new LogicaEstudiante();
             
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            int numero;
            String valido = "";
            bool correcto = true;
            if (txtIdentificacion.Text.Length >= 8 && txtIdentificacion.Text.Length <= 12 && int.TryParse(txtIdentificacion.Text, out numero))
            {
                valido = logEst.validarIdentificacion(txtIdentificacion.Text);
                if (!valido.Equals("No existe"))
                {
                    MessageBox.Show("El Estudiante no existe.");
                    correcto = false;
                }
            }
            else
            {
                MessageBox.Show("Formato de identificación no válido.");
                correcto = false;
            }

            if (correcto)
            {

            }
        }
    }
}
