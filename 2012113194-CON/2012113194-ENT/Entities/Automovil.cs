using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT
{
    public class Automovil : Carro
    {
        public int AutomovilId { get; set; }
        public TipoAuto TipoAuto { get; set; }

        public Automovil(Volante volante, Parabrisas parabrisas, int numLlantas,
                         int numAsientos, Propietario propietario, TipoCarro tipoCarro, TipoAuto tipoAuto)
            : base(volante, parabrisas, numLlantas, numAsientos, propietario, tipoCarro)
        {
            TipoAuto = tipoAuto;
        }

        public Automovil()
        {
            TipoAuto = TipoAuto.NoDefinido;
        }
    }

    }
