using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipmentsDTO : AbstractDTO<int> {
    public ShippingCompanyEnum ShippingCompany { get; set; }
    public int ShipOrderId { get; set; }
    public long TrackingNumber { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateDelivered { get; set; }  
    public DateTime? DateShipped { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public Byte[]? RowVersion { get; set; }

    public ShipOrdersDTO ShipOrders {get; set;} = null!;
    public ShipmentsDTO() { }
    //<summary>
    //Constructeur vide pour la classe abstractDTOService (<see cref="Business.Abstracts.AbstractDtoService{DtoType, DtoIdType}"/> only).
    //<summary>
    public ShipmentsDTO(ShippingCompanyEnum shippingCompany, int shipOrderId) {
        this.ShippingCompany = shippingCompany;
        this.ShipOrderId = shipOrderId;
    }
    /// <summary>
    /// Initialise un constructeur complet pour EF Core
    /// </summary>
    /// <param name="shippingCompany">La compagnie de livraison</param>
    /// <param name="shipOrderId">L'id de l'ordre d'expédition associé</param>
    /// <param name="trackingNumber">Le numéro de suivi</param>
    /// <param name="dateCreated">La date de création de la livraison dans la base de donnée</param>
    /// <param name="dateUpdated">La date de mise à jour de la livraison dans la base de donnée</param>
    /// <param name="dateCompleted">La date de complétion de la livraison</param>
    /// <param name="dateDeleted">La date de suppression de la livraison dans la base de donnée</param>
    /// <param name="rowversion">La version de la ligne</param>
    protected ShipmentsDTO(ShippingCompanyEnum shippingCompany, int shipOrderId, long trackingNumber, DateTime? dateCreated, DateTime? dateUpdated, 
        DateTime? dateCompleted, DateTime? dateShipped, DateTime? dateDeleted, byte[] rowversion) : this(shippingCompany, shipOrderId) {
        this.ShippingCompany = shippingCompany;
        this.ShipOrderId = shipOrderId;
        this.TrackingNumber = trackingNumber;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateDelivered = dateCompleted;
        this.DateShipped = dateShipped;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowversion;
    }

    public override string ToString() {
        return this.Id.ToString() + "-" + this.ShippingCompany.ToString() + "-" + this.DateShipped.ToString();

    }
}
