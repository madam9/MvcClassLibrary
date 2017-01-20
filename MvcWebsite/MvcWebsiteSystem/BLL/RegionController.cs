using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcWebsiteSystem.Entities;

namespace MvcWebsiteSystem.BLL
{
    public class RegionController
    {
        public Region Region_Get(int regionid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Regions.Find(regionid);
            }
        }

        public List<Region> Region_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Regions.ToList();
            }
        }
    }
}
