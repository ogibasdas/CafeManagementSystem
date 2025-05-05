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
    public class FtrMngr : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FtrMngr(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void TAdd(Feature entity)
        {
            _featureDal.Add(entity);   
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
