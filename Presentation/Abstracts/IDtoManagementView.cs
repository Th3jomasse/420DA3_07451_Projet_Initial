using _420DA3_07451_Projet_Initial.DataAccess.Abstracts;

namespace _420DA3_07451_Projet_Initial.Presentation.Abstracts;
public interface IDtoManagementView<DtoType> where DtoType : class, IDto {


    public DialogResult OpenForCreation(DtoType blankInstance);

    public DialogResult OpenForVisualization(DtoType instance);

    public DialogResult OpenForEdition(DtoType instance);

    public DialogResult OpenForDeletion(DtoType instance);

}
