using OM.Business.Abstract;
using OM.DataAccess.Abstract;
using OM.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Concrete
{
    public class DscntMngr : IDiscountService

    {
        private readonly IDiscountDal _discountDal;
        public DscntMngr(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }
    
        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount TGetByID(int id)
        {
            return _discountDal.GetByID(id);

        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();

        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
