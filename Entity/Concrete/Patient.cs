using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Patient : IEntity
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string description { get; set; }
        public string PhoneNumber { get; set; }
        public string appointment { get; set; }

    }
}
