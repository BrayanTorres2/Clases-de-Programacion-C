using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Taller31AccesoDatos.Configuracion
{
    public static class ParametrosApp {
        private static readonly ConfiguracionApp _conf;
        //TODO:
        /*
            1. Cree la propiedad static CONF
            2. Solo sera de obtencion, get de la variable _conf
        */

        static ParametrosApp()
        {            
            _conf = ObtenerConfiguracionApp();
        }

        private static ConfiguracionApp ObtenerConfiguracionApp() {
            ConfiguracionApp configuracionApp = null;
            MapeadorConfiguracion configuracionMapeada = null;
            TipoConfiguracionAmbiente tipoConfiguracionAmbiente = 0;
            IConfigurationRoot config = null;

            IConfigurationBuilder builder = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json");

            config = builder.Build();
            configuracionMapeada = config.GetSection("Ambiente").Get<MapeadorConfiguracion>();

            Enum.TryParse<TipoConfiguracionAmbiente>(configuracionMapeada.ambienteEjecucion.ToUpper(), out tipoConfiguracionAmbiente);

            switch (tipoConfiguracionAmbiente)
            {
                //TODO
                /*
                    1. Establezca el caso para cuando sea desarrollo, este valor lo establece la ENUM TipoConfiguracionAmbiente
                */
                case :
                    configuracionApp = new ConfiguracionApp {
                        AMBIENTE_EJECUCION = tipoConfiguracionAmbiente,
                        parametros = configuracionMapeada.desarrollo
                    };
                    break;
                /*
                    2. Establezca el caso para cuando sea produccion, este valor lo establece la ENUM TipoConfiguracionAmbiente
                */
                case :
                    configuracionApp = new ConfiguracionApp {
                        AMBIENTE_EJECUCION = tipoConfiguracionAmbiente,
                        parametros = configuracionMapeada.produccion
                    };
                    break;                
                default:
                    configuracionApp = null;
                    break;
            }
            
            return configuracionApp;
        }
    }
}
