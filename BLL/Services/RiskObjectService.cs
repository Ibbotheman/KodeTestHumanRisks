using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL.Services
{
    public class RiskObjectService
    {
        DAL.Controller.RiskObjectData context;

        public RiskObjectService()
        {
            context = new DAL.Controller.RiskObjectData();
        }

        public List<RisksObject> GetAll()
        {
            return context.GetAll();
        }

        public RisksObject Get(int id)
        {
            return context.Get(id);
        }

        public RisksObject Create(string title, string desc)
        {
            return context.Create(title, desc);
        }

        public void Delete(int id)
        {
            context.Delete(id);
        }

        public void Update(int id)
        {
            context.Update(id);
        }
    }
}
