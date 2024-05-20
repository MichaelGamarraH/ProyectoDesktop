using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSoft.RetailSoftVentas
{
    public class DatosCompartidos
    {
        public static event EventHandler<string> OnTextoLabelCambiado;

        private static string textoLabel;

        public static string TextoLabel
        {
            get { return textoLabel; }
            set
            {
                if (value != textoLabel)
                {
                    textoLabel = value;
                    OnTextoLabelCambiado?.Invoke(null, textoLabel);
                }
            }
        }
    }
}
