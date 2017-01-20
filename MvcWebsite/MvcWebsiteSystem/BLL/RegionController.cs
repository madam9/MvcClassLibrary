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
        public int Region_Create(Region newitem)
        {
            using (var context = new NorthwindContext())
            {
                //on the add, the process will return a copy of the new item from the database
                Region addeditem = context.Regions.Add(newitem);
                //YOU MUST REQUEST THAT THE CHANGES TO THE DATABASE BE SAVED
                context.SaveChanges();
                return addeditem.RegionID;
            }
        }

        public void Region_Delete(int regionid)
        {
            using (var context = new NorthwindContext())
            {
                //retrieve the existing record from the database
                Region existing = context.Regions.Find(regionid);

                //physcial request the removal to the existing record (instance)
                context.Regions.Remove(existing);

                //if, for some reason you cannot physically remove a record
                //you may need to logically indicate the record is not to be used
                //existing.theflagattributefieldname = desiredvalue;
                //context.Entry(existing).Property("theflagattributefieldname").IsModified = true;

                //YOU MUST REQUEST THAT THE CHANGES TO THE DATABASE BE SAVED
                context.SaveChanges();

            }
        }

    }

}

