using _2012113194_ENT;
using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public BusRepository(EnsambladoraDbContext _Context)
        {
            this._Context = _Context;
        }

        private BusRepository()
        {

        }
    }
}
