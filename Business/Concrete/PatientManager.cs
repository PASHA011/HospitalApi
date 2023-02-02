using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;
        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }
        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult(/*message*/);
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult();
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll());
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult();
        }
    }
}
