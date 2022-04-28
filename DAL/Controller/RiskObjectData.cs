using DAL.EntityFramework;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Controller
{
    public class RiskObjectData
    {
        RiskObjectContext context;
        public RiskObjectData()
        {
            context = new RiskObjectContext();
        }
        public List<RisksObject> GetAll()
        {
            return context.RisksObjects.ToList();
        }

        public RisksObject Get(int id)
        {
            return context.RisksObjects.Find(id);
        }

        public RisksObject Create(string title, string desc)
        {
            var riskObject = new RisksObject { Title = title, Description = desc };
            context.RisksObjects.Add(riskObject);
            context.SaveChanges();
            return riskObject;
        }

        public void Delete(int id)
        {
            context.RisksObjects.Remove(Get(id));
            context.SaveChanges();
        }

        public RisksObject Update(int id, string title, string desc)
        {
            var recordToUpdate = Get(id);
            recordToUpdate.Title = title;
            recordToUpdate.Description = desc;

           
            context.RisksObjects.Update(recordToUpdate);
            context.SaveChanges();

            return recordToUpdate;
        }

    }

    
}
