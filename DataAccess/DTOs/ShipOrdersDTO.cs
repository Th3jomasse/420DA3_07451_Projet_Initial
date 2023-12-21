using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;


public class ShipOrdersDTO: AbstractDTO<int> {
    //Propriétés des colonnes
    public int WarehouseId { get; set; }
    public string DestName { get; set; }
    public string DestFirstName { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public int CustomerId { get; set; }

    public DateTime ShipOrderDate { get; set; }//la date à laquelle la commande à été faite par le client
    public ShipOrderEnum Status { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateCompleted { get; set; }//La date à laquelle la commande a été completée
    public byte[] RowVersion { get; set; } = null!;

    //propriétés de navigation
    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();
    public ProduitsDTO Produit { get; set; }
    public ShipmentsDTO Shipment { get; set; }
    public ClientDTO Client { get; set; } = null!;
    public EntrepotDTO Warehouse { get; set; } = null!;

    //<summary>
    //Constructeur vide pour la classe abstractDTOService (<see cref="Business.Abstracts.AbstractDtoService{DtoType, DtoIdType}"/> only).
    //<summary>
    public ShipOrdersDTO() { }
  


    /// <summary>
    /// Initialise un constructeur de base
    /// </summary>
    /// <param name="warehouseid">L'id de l'entrepôt associé</param>
    /// <param name="destName">Le nom du destinataire de la commande</param>
    /// <param name="destFirstName">Le prénom du destinataire de la commande</param>
    /// <param name="address">L'addresse du destinataire de la commande</param>
    /// <param name="postalCode">Le code postal du destinataire de la commande</param>
    /// <param name="customerId">Le client associé</param>
    /// <param name="shipOrderDate">La date de création de la commande par le client</param>
    public ShipOrdersDTO(int warehouseid, string destName, string destFirstName, string address,
    string postalCode, int customerId, DateTime shipOrderDate) {
        this.WarehouseId = warehouseid;
        this.DestName = destName;
        this.DestFirstName = destFirstName;
        this.Address = address;
        this.PostalCode = postalCode;
        this.CustomerId = customerId;
        this.ShipOrderDate = shipOrderDate;
        this.Status = ShipOrderEnum.NEW;
    }


    /// <summary>
    /// Initialise un constructeur complet pour EF Core
    /// </summary>
    /// <param name="warehouseid">L'id de l'entrepôt associé</param>
    /// <param name="destName">Le nom du destinataire de la commande</param>
    /// <param name="destFirstName">Le prénom du destinataire de la commande</param>
    /// <param name="address">L'addresse du destinataire de la commande</param>
    /// <param name="postalCode">Le code postal du destinataire de la commande</param>
    /// <param name="customerId">Le client associé</param>
    /// <param name="status">Le status de la commande</param>
    /// <param name="shipOrderDate">La date de création de la commande par le client</param>
    /// <param name="dateCreated">La date de création de la commande dans la base de donnée</param>
    /// <param name="dateUpdated">La date de mise à jour de la commande dans la base de donnée</param>
    /// <param name="dateCompleted">La date de complétion de la commande</param>
    /// <param name="dateDeleted">La date de suppression de la commande dans la base de donnée</param>
    /// <param name="rowversion">La version de la ligne</param>
    protected ShipOrdersDTO(int warehouseid,  string destName, string destFirstName, string address,
    string postalCode, int customerId, ShipOrderEnum status, DateTime shipOrderDate, DateTime dateCreated, DateTime dateUpdated, 
    DateTime dateCompleted, byte[] rowversion, DateTime? dateDeleted) : this(warehouseid,  destName, destFirstName, address, postalCode, customerId,
     shipOrderDate) {
        this.WarehouseId = warehouseid;
        this.DestName = destName;
        this.DestFirstName = destFirstName;
        this.Address = address;
        this.PostalCode = postalCode;
        this.CustomerId = customerId;
        this.ShipOrderDate = shipOrderDate;
        this.Status = status;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateCompleted = dateCompleted;
        this.RowVersion = rowversion;
        this.DateDeleted = dateDeleted;
    }

        public override string ToString() {
        return this.Id.ToString() + "-" + this.ShipOrderDate.ToString() + "-" + this.Status.ToString();

    }
}


