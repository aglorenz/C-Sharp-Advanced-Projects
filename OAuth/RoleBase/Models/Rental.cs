using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleBase.Models
{
    public class Rental
    {
        public int ID { get; set; }
        public int RentalAgreement { get; set; }
        public string Person { get; set; }
    }
}