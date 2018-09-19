using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace logica
{
    public class LogicaMatricula
    {

        DatosMatricula matricula = new DatosMatricula();

        
        public String asignaturaSeleccionada(String asignatura, string identificacion)
        {
            DataTable table = new DataTable();
            table = matricula.buscarAsignatura(asignatura,identificacion);
            if (table.Rows.Count > 0)
            {
                return "Existe";
            }
            else
            {
                return "No existe";

            }

        }
    }
}
