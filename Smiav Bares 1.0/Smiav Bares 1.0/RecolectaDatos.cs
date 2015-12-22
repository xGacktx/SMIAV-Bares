using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smiav_Bares_1._0
{
    public class DatosComanda
    {
        private static DatosComanda datos;

        private DatosComanda()
        {
        }

        public static DatosComanda Instance()
        {
            if (datos == null)
            {
                datos = new DatosComanda();
            }

            return datos;
        }

        public string id { get; set; }
        public string id_venta { get; set; }
        public string rut_garzon { get; set; }
        public string num_mesa { get; set; }
        public string fecha { get; set; }
        public string estado { get; set; }
    }
}
