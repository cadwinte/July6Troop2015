using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails7Repo.Data.Models
{
    public interface ITrailRepository
    {
        IEnumerable<Trail> GetAll();
        Trail Get(int id);
        Trail Add(Trail item);
        void Remove(int id);
        bool Update(Trail item);
    }
}
