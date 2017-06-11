using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194_ENT.IRepositories
{
    public interface ICarroRepository : IRepository<Carro>
    {
        void Delete(Parabrisas parabrisas);
        void Add(Cinturon cinturon);
    }
}
