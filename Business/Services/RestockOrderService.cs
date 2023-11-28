using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
internal class RestockOrderService : AbstractDtoService<RestockOrderDTO, int> {
    private AbstractFacade facade;
    protected override RestockOrderDAO Dao { get; }
    protected override RestockOrderManagementForm DtoManagementWindow { get; }

    public RestockOrderService(AbstractFacade facade, AbstractContext context) {
        this.facade = facade;
        facade.RegisterDependent(this);
        this.Dao = new RestockOrderDAO(context);
        this.DtoManagementWindow = new RestockOrderManagementForm(facade);
    }


    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }


    /// <summary>
    /// A UTILISER APRÈS LA CRÉATION COMPLÈTE DE NOUVELLES <see cref="ShipOrdersDTO"/>
    /// (après avoir diminué la quantité en stock de ses produits).
    /// <para>
    /// Vérifie si les produits de la liste reçue ont besoin d'être restockés et
    /// crée une nouvelle <see cref="RestockOrderDTO"/> pour ceux dont c'est le cas.
    /// </para>
    /// </summary>
    /// <param name="produits">La liste de produits à vérifier.</param>
    /// <returns>La liste de <see cref="RestockOrderDTO"/> créés.</returns>
    public List<RestockOrderDTO> RestockProduitsIfNeeded(List<ProduitsDTO> produits) {
        List<RestockOrderDTO> newROs = new List<RestockOrderDTO>();
        foreach (ProduitsDTO produit in produits) {
            if (produit.UnitesEnStock < (0.5 * produit.NiveauDeReappro)) {
                int quantityNeeded = produit.NiveauDeReappro - produit.UnitesEnStock;
                newROs.Add(this.CreateRestockOrderFor(produit, quantityNeeded));
            }
        }
        return newROs;
    }

    public List<RestockOrderDTO> GetAllIncompleteForWarehouse(WarehouseDTO warehouse) {
        return this.Dao.GetAllIncompleteForWarehouse(warehouse);
    }

    public List<RestockOrderDTO> GetAllIncompleteForWarehouse(int warehouseId) {
        return this.Dao.GetAllIncompleteForWarehouse(warehouseId);
    }

    private RestockOrderDTO CreateRestockOrderFor(ProduitsDTO produit, int quantity) {
        // FIXME: ProduitDTO n'a pas ses propriétés de navigation
        WarehouseDTO targettedWarehouse;
        RestockOrderDTO newRO = new RestockOrderDTO(targettedWarehouse.Id, produit.Id, quantity);
        return this.Dao.Create(newRO);
    }
}
