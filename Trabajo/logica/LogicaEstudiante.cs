using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace logica
{
    public class LogicaEstudiante
    {

        DatosEstudiante estudiante = new DatosEstudiante();

        public String validarIdentificacion(String identificacion)
        {
            DataTable table = new DataTable();
            table = estudiante.buscarEstudiante(identificacion);
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
