using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Business.Abstract
{
   public interface IGenericService<T>  where T : class
    {
        //GenericDaldekilerle karismasin diye basa T ekledim.
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetByID(int id);
        List<T> TGetListAll();

    }
}
