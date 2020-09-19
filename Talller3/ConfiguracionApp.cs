using System;
using System.Collections.Generic;

namespace Taller31AccesoDatos.Configuracion
{
    public class ConfiguracionApp {
        public TipoConfiguracionAmbiente AMBIENTE_EJECUCION { get; set; }
        public ParametroAmbiente parametros { get; set; }

        public ConfiguracionApp()
        {            
        }
    }
}
