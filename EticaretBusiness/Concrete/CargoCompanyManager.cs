using ETicaretBusiness.Abstract;
using ETicaretDataAccessLayer.Abstract;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBusiness.Concrete
{
    public class CargoCompanyManager : ICargoCompanyService
    {
        private ICargoCompanyDal cargoCompanyDal;
        public CargoCompanyManager(ICargoCompanyDal _cargoCompanyDal)
        {
            cargoCompanyDal = _cargoCompanyDal;
        }
        public void Add(CargoCompany entity)
        {
            cargoCompanyDal.Add(entity);
        }

        public void Delete(CargoCompany entity)
        {
            cargoCompanyDal.Delete(entity); 
        }

        public CargoCompany? Get(int? entityId)
        {
           return cargoCompanyDal.GetById(entityId);
        }

        public IEnumerable<CargoCompany> GetAll()
        {
            return cargoCompanyDal.GetAll();
        }

        public void Update(CargoCompany entity)
        {
            cargoCompanyDal.Update(entity);
        }
    }
}
