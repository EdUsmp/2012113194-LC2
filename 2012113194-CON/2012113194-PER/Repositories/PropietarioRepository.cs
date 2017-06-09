using _2012113194_ENT;
using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    public class PropietarioRepository : Repository<Propietario>, IPropietarioRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public PropietarioRepository()
        {

        }

        public PropietarioRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        IEnumerable<Propietario> IPropietarioRepository.GetActorWithCarros(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Add(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.AddRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        Propietario IRepository<Propietario>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.Find(System.Linq.Expressions.Expression<Func<Propietario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Update(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.UpdateRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Delete(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.DeleteRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }
    }
}
