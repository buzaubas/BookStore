using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.lib
{
    public class UserService
    {
        public ModelEntity db = new ModelEntity();

        public List<City> GetCities()
        {
            return db.Cities.ToList();
        }

        
    }

}
