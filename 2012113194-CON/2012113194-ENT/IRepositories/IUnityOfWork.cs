using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAsientoRepository Asiento { get; }
        IAutomovilRepository Automovil { get; }
        IBusRepository Bus { get; }
        ICarroRepository Carro { get; }
        ICinturonRepository Cinturon { get; }
        IEnsambladoraRepository Ensambladora { get; }
        ILlantaRepository Llanta { get; }
        IParabrisasRepository Parabrisas { get; }
        IPropietarioRepository Propietario { get; }
        IVolanteRepository Volante { get; }

        int SaveChanges();
    }
}
