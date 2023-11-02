using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business;
public class ExampleService : IService {
    private readonly ExampleDAO dao;
    private readonly ExampleDtoForm dtoWindow;

    public ExampleService(AbstractApplication app, ExampleContext context) {
        app.RegisterService(this);
        this.dao = new ExampleDAO(context);
        this.dtoWindow = new ExampleDtoForm(this);
    }

    public void Shutdown() {
        this.dtoWindow.Dispose();
    }

    public List<ExampleDTO> GetAllExamples() {
        return this.dao.GetAll();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>The created Example instance or null if the user cancelled the action</returns>
    public ExampleDTO? CreateNewExample() {
        ExampleDTO newInstance = new ExampleDTO("", null);
        return this.dtoWindow.OpenForCreation(newInstance) == DialogResult.OK ? this.dao.Create(newInstance) : null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>The viewed Example instance or null if the user cancelled the action</returns>
    public ExampleDTO? DisplayExample(ExampleDTO instance) {
        return this.dtoWindow.OpenForVisualization(instance) == DialogResult.OK ? instance : null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>The updated Example instance or null if the user cancelled the action</returns>
    public ExampleDTO? EditExample(ExampleDTO instance) {
        return this.dtoWindow.OpenForEdition(instance) == DialogResult.OK ? this.dao.Update(instance) : null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>The deleted Example instance or null if the user cancelled the action</returns>
    public ExampleDTO? DeleteExample(ExampleDTO instance) {
        return this.dtoWindow.OpenForDeletion(instance) == DialogResult.OK ? this.dao.Delete(instance) : null;
    }
}
