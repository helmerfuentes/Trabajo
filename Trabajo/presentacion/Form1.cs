using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            int numero;
            String valido = "";
            if (txtIdentificacion.Text.Length >= 8 && txtIdentificacion.Text.Length <= 12 && int.TryParse(txtIdentificacion.Text, out numero))
            {
                valido = logEst.validarEstudiante(txtIdentificacion.Text);
                if (!valido.Equals("Existe"))
                {
                    MessageBox.Show("El Estudiante no existe..");
                }
            }
            else
            {
                
            }
        }
    }
}
