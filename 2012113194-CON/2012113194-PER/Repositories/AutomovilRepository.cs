using _2012113194_ENT;
using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    public class AutomovilRepository : Repository<Automovil>, IAutomovilRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public AutomovilRepository(EnsambladoraDbContext _Context)
        {
            this._Context = _Context;
        }

        private AutomovilRepository()
        {

        }
    }
}
