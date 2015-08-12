using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails7Repo.Data.Models
{
    public class TrailRepository : ITrailRepository 
    {
        private List<Trail> trails = new List<Trail>();
        private int _nextId = 1;

        public TrailRepository()
        {
            Add(new Trail { Trailnumber = 1, Name = "Givens, Spicer & Lowry Trail", Status = "Clear", Time = "August 8th, 2015, 3:00 pm" });
            Add(new Trail { Trailnumber = 2, Name = "Lighthouse Trail", Status = "Clear", Time = "August 8th, 2015, 2:45 pm" });
            Add(new Trail { Trailnumber = 3, Name = "Capitol Peak Trail", Status = "Clear", Time = "August 7th, 2015, 5:15 am" });
            Add(new Trail { Trailnumber = 4, Name = "Little Fox Canyon Trail", Status = "Clear", Time = "August 9th, 2015, 7:30 am" });
        }

        public IEnumerable<Trail> GetAll()
        {
            return trails;
        }

        public Trail Get(int id)
        {
            return trails.Find(p => p.Id == id);
        }

        public Trail Add(Trail trail)
        {
            if (trail == null)
            {
                throw new ArgumentNullException("trail");
            }
            trail.Id = _nextId++;
            trails.Add(trail);
            return trail;
        }

        public void Remove(int id)
        {
            trails.RemoveAll(t => t.Id == id);
        }

        public bool Update(Trail trail)
        {
            if (trail == null)
            {
                throw new ArgumentNullException("trail");
            }
            int index = trails.FindIndex(t => t.Id == trail.Id);
            if (index == -1)
            {
                return false;
            }
            trails.RemoveAt(index);
            trails.Add(trail);
            return true;
        }
    }
}
