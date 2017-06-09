using _2012113194_ENT;
using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    public class VolanteRepository : Repository<Volante>, IVolanteRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public VolanteRepository(EnsambladoraDbContext _Context)
        {
            this._Context = _Context;
        }

        private VolanteRepository()
        {

        }
    }
}
