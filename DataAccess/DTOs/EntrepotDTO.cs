using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class EntrepotDTO : AbstractDTO<int> {
    public const int NOM_ENTREPOT_MAX_LENGTH = 128;


    public string NomEntrepot {  get; set; }
    public int AddressId { get; set; }
    public byte[] Version { get; set; }


    public AddressDTO Address { get; set; }
    public List<ClientDTO> Clients { get; set; }
    
    public List<RestockOrderDTO> RestockOrders { get; set; }

    public EntrepotDTO() { }

    public EntrepotDTO(int id, string nomEntrepot, int addressId, byte[] version) {
        this.Id = id;
        this.NomEntrepot = nomEntrepot;
        this.AddressId = addressId;
        this.Version = version;
    }


    public override string ToString() {
        return this.Id + " - " + this.NomEntrepot;
    }
}
