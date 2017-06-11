using _2012113194_ENT;
using _2012113194_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_PER.Repositories
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        //private readonly EnsambladoraDbContext _Context;

        //public CarroRepository(EnsambladoraDbContext _Context)
        //{
        //    this._Context = _Context;
        //}

        //private CarroRepository()
        //{

        //}
        public CarroRepository(EnsambladoraDbContext context):base(context)
		{

        }
    }
}
