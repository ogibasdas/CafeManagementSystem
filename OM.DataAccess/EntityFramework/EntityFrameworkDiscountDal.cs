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
    public class EntityFrameworkDiscountDal : GenericRepo<Discount>, IDiscountDal
    {
        public EntityFrameworkDiscountDal(SignalRContext context) : base(context)
        {
        }
    }
}
