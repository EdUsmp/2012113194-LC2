using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT
{
    public class Carro
    {

        public TipoCarro TipoCarro { get; set; }
        public Volante Volante { get; set; }
        public Parabrisas Parabrisas { get; set; }
        public Propietario Propietario { get; set; }
        public Bus Bus { get; set; }
        public Automovil Automovil { get; set; }
        public Ensambladora Ensambladora { get; set; }
        public List<Llanta> Llantas { get; set; }

        public List<Asiento> Asientos { get; set; }

        public Carro()
        {
            Llantas = new List<Llanta>();
            Asientos = new List<Asiento>();
        }

       /* public Carro(Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos, Propietario propietario, TipoCarro tipocarro)
        {
            Llantas = new List<Llanta>(numLlantas);
            Asientos = new List<Asiento>(numAsientos);

            Volante = volante;
            Parabrisas = parabrisas;
            Propietario = propietario;
            TipoCarro = tipocarro;
        }*/
        public string NumSerieChasis { get; set; }
    }
}
