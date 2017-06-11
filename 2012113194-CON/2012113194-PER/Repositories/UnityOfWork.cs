using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012113194_ENT;

namespace _2012113194_PER.Repositories
{
    //36:10
    public class UnityOfWork : IUnityOfWork
    {
        private readonly EnsambladoraDbContext _Context;

        public IAsientoRepository Asiento { get; private set; }
        public ICarroRepository Carro { get; private set; }
        public ICinturonRepository Cinturon { get; private set; }
        public ILlantaRepository Llanta { get; private set; }
        public IParabrisasRepository Parabrisas { get; private set; } 
        public IPropietarioRepository Propietario { get; private set; }
        public IVolanteRepository Volante { get; private set; }
        public static UnityOfWork Instance { get; set; }

        public object Cinturons
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public UnityOfWork(EnsambladoraDbContext context)
        {
            _Context = context;

            Asiento = new AsientoRepository(_Context);
            Carro = new CarroRepository(_Context);
            Cinturon = new CinturonRepository(_Context);
            Llanta = new LlantaRepository(_Context);
            Parabrisas = new ParabrisasRepository(_Context);
            Propietario = new PropietarioRepository(_Context);
            Volante = new VolanteRepository(_Context);
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
