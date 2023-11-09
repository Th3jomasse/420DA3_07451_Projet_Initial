using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ProduitsDTO : AbstractDTO<int> {
    public string Nom { get; set; }
    public string Description { get; set; }
    public int FournisseurId { get; set; }
    public int CategorieId { get; set; }
    public decimal PrixUnitaire { get; set; }
    public int UnitesEnStock { get; set; }
    public int UnitesCommandees { get; set; }
    public int NiveauDeReappro { get; set; }
    public bool Suspendu { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateDeleted { get; set; }
    
}
