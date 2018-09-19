using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace logica
{
    public class LogicaAsignatura
    {
        DatosAsignatura asignatura = new DatosAsignatura();
        public String validarAsignatura(String codigoMateria)
        {
            DataTable table = new DataTable();
            table = asignatura.buscarAsignatura(codigoMateria);
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