using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class RestockOrderDTO : AbstractDTO<int> {

    // Data Properties
    public RestockOrderStatusEnum Status { get; set; }
    public int DestinationWarehouseId { get; set; }
    public int ProduitId { get; set; }
    public int Quantity { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? CompletionDate { get; set; }
    public byte[] Rowversion { get; set; } = null!;


    // Navigation Properties
    public EntrepotDTO DestinationWarehouse { get; set; } = null!;
    public ProduitsDTO Produit { get; set; } = null!;


    #region Constructors

    /// <summary>
    /// Empty contructor (for <see cref="Business.Abstracts.AbstractDtoService{DtoType, DtoIdType}"/> only).
    /// </summary>
    public RestockOrderDTO() { }

    /// <summary>
    /// Usable constructor
    /// </summary>
    /// <param name="destinationWarehouseId">Id de l'entrepôt</param>
    /// <param name="produitId">Id du produit</param>
    /// <param name="quantity">Quantité du produit</param>
    public RestockOrderDTO(int destinationWarehouseId, int produitId, int quantity) {
        this.Status = RestockOrderStatusEnum.PENDING;
        this.DestinationWarehouseId = destinationWarehouseId;
        this.ProduitId = produitId;
        this.Quantity = quantity;
    }

    /// <summary>
    /// Protected constructor for EF Core only.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="status"></param>
    /// <param name="destinationWarehouseId"></param>
    /// <param name="produitId"></param>
    /// <param name="quantity"></param>
    /// <param name="creationDate"></param>
    /// <param name="completionDate"></param>
    /// <param name="rowversion"></param>
    protected RestockOrderDTO(int id, RestockOrderStatusEnum status, int destinationWarehouseId,
        int produitId, int quantity, DateTime creationDate, DateTime completionDate, 
        byte[] rowversion) {
        this.Id = id;
        this.Status = status;
        this.DestinationWarehouseId = destinationWarehouseId;
        this.ProduitId= produitId;
        this.Quantity = quantity;
        this.CreationDate = creationDate;
        this.CompletionDate = completionDate;
        this.Rowversion = rowversion;

    }

    #endregion


    #region Validation Methods

    public static bool ValidateQuantity(int quantity, bool optThrowExceptions = false) {
        try {
            if (quantity < 1) {
                throw new Exception("Product quantity cannot be < 1");
            }
            return true;

        } catch (Exception ex) {
            return optThrowExceptions ?
                throw new Exception("Invalid product quantity.", ex)
                : false;
        }
    }

    #endregion


}
