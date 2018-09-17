using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class DatosEstudiante: Conexion()
    {
        public MySqlCommand cmd;

        public DataTable buscarEstudiante(String identificasion)
        {
            try
            {
                if (conectar())
                {
                    cmd = new MySqlCommand("buscarEstudiante");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Add(new MySqlParameter("xidentificacion", identificasion));

                    int i = cmd.ExecuteNonQuery();

                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        return llenarDataTable(cmd);
                    }
                    else
                        return null;
                }
                else
                {
                    return null;
                }



            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                desConectar();
            }
        }
    }
}

