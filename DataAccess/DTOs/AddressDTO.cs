using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
internal class AddressDTO : AbstractDTO<int> {
    public int ID { get; set; }
    public int CivicNumber { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
}
