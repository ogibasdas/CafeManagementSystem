using Microsoft.EntityFrameworkCore;
using OM.DataAccess.Abstract;
using OM.DataAccess.Concrete;
using OM.DataAccess.Repositories;
using OM.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.DataAccess.EntityFramework
{
    public class EntityFrameworkProductDal : GenericRepo<Product>, IProductDal
    {
        public EntityFrameworkProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;

        }
    }
}
