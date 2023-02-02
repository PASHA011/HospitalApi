using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        public IResult Add(Doctor product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Doctor product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Doctor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Doctor product)
        {
            throw new NotImplementedException();
        }
    }
}
