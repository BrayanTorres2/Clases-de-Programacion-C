using System;
using System.Collections.Generic;

namespace Taller31AccesoDatos.Configuracion
{
    public class MapeadorConfiguracion {
        public string ambienteEjecucion { get; set; }
        public ParametroAmbiente desarrollo { get; set; }        
        public ParametroAmbiente produccion { get; set; }

        public MapeadorConfiguracion()
        {            
        }
    }
}
