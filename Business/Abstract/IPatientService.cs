using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();
        IResult Add(Patient patient);
        IResult Delete(Patient patient);
        IResult Update(Patient patient);
    }
}
