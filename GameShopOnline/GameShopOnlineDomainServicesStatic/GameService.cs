using GameShopOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShopOnline;

namespace GameShopOnlineDomainServicesStatic
{
    public class GameService : BaseService<Game>
    {
        private readonly List<Game> entities = new List<Game>();

        public Game Add(Game entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Game> Get()
        {
            throw new NotImplementedException();
        }

        public Game Get(int id)
        {
            throw new NotImplementedException();
        }

        public Game Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
