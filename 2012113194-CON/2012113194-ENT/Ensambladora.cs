using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT
{
    class Ensambladora
    {
        public List<Carro> Carros { get; set; }

        public Ensambladora()
        {
            Carros = new List<Carro>();
        }


        public Carro EnsamblarCarro(TipoCarro tipoCarro, TipoAuto tipoAuto, TipoBus tipoBus)
        {
            Carro carro;

            if (tipoCarro == TipoCarro.Automovil)
                carro = new Automovil(new Volante(), new Parabrisas(), 4, 5, null, TipoCarro.Automovil, tipoAuto);
            else
                carro = new Bus(new Volante(), new Parabrisas(), 4, 10, null, TipoCarro.Bus, tipoBus);

            return carro;
        }

        
        
    }
}
