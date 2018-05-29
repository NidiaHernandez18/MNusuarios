using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnusuarios
{
    
    public class Neg_Consultas
    {
        db_ConfiguracionesDataContext db = new db_ConfiguracionesDataContext();


        public Array sistemas()
        {
            var consulta = from s in db.Configuracion_empresas
                           group s by new { s.sistema }  into sistema
                           select sistema;

            return consulta.ToArray();
        }
    }
}