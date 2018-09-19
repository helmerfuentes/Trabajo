using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Horario
    {
        public int idHorarios {
            get;set;
        }
        public int idGrupo
        {
            get; set;
        }

        public string dia {
            get;set;
        }
        public DateTime horarioInicio {
            get;set;
        }
        public DateTime horarioFinal {
            get;set;
        }

    }
}
