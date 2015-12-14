using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline.Services
{
    public interface IDomainService<T> where T :BaseModel
    {
        T Add(T entity);

        T Get(int id);

        List<T> Get();

        T Update(T entity);

        void Delete(int id);
    }
}
