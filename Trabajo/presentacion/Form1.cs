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
        LogicaMatricula logMatr = new LogicaMatricula();
        LogicaGrupo logGrupo = new LogicaGrupo();
             
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
                valido = logEst.validarIdentificacion(txtIdentificacion.Text);
                if (valido.Equals("Existe"))
                {
                    if (txtAsignatura.Text.Length != 5)
                    {
                        valido = logMatr.asignaturaSeleccionada(txtAsignatura.Text, txtIdentificacion.Text);
                        if (valido.Equals("No existe"))
                        {
                            if (txtGrupo.Text.Length <=2 && int.TryParse(txtGrupo.Text, out numero))
                            {
                                valido = logGrupo.disponibilidad(int.Parse(txtGrupo.Text));
                            }
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("El Estudiante no existe.");
                }
            }
            else
            {
                MessageBox.Show("Formato de identificación no válido.");
            }
        }
    }
}
