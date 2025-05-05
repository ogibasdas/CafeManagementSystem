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
    public class RefMngr : IReferenceService
    {
        private readonly IReferenceDal _referenceDal;
        public RefMngr(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }
        public void TAdd(Reference entity)
        {
            _referenceDal.Add(entity);
        }

        public void TDelete(Reference entity)
        {
            _referenceDal.Delete(entity);
        }

        public Reference TGetByID(int id)
        {
            return _referenceDal.GetByID(id);
        }

        public List<Reference> TGetListAll()
        {
            return _referenceDal.GetListAll();
        }

        public void TUpdate(Reference entity)
        {
            _referenceDal.Update(entity);
        }
    }
}
