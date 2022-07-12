using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdersServiceDAL.Repositories
{
    public interface IRepository<TDbModel>
    {
        Task<List<TDbModel>> GetAll();

        Task Add(TDbModel newEntity);

        Task Clear();
    }
}