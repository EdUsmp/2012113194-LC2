using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    //36:10
    public class UnityOfWork : IUnityOfWork
    {
        private readonly EnsambladoraDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAsientoRepository Asiento { get; private set; }
        public IAutomovilRepository Automovil { get; private set; }
        public IBusRepository Bus { get; private set; }
        public ICarroRepository Carro { get; private set; }
        public ICinturonRepository Cinturon { get; private set; }
        public IEnsambladoraRepository Ensambladora { get; private set; }
        public ILlantaRepository Llanta { get; private set; }
        public IParabrisasRepository Parabrisas { get; private set; } 
        public IPropietarioRepository Propietario { get; private set; }
        public IVolanteRepository Volante { get; private set; }

        private UnityOfWork()
        {
            _Context = new EnsambladoraDbContext();

            Asiento = new AsientoRepository(_Context);
            Automovil = new AutomovilRepository(_Context);
            Bus = new BusRepository(_Context);
            Carro = new CarroRepository(_Context);
            Cinturon = new CinturonRepository(_Context);
            Ensambladora = new EnsambladoraRepository(_Context);
            Llanta = new LlantaRepository(_Context);
            Parabrisas = new ParabrisasRepository(_Context);
            Propietario = new PropietarioRepository(_Context);
            Volante = new VolanteRepository(_Context);
        }

        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                    return _Instance;
                }               
            }
        }
        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
