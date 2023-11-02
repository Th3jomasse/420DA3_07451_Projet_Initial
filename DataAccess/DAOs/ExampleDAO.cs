using _420DA3_07451_Projet_Initial.DataAccess.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ExampleDAO : IDao<ExampleDTO, int> {

    private readonly ExampleContext context;

    public ExampleDAO(ExampleContext context) {
        this.context = context;
    }


    public List<ExampleDTO> GetAll() {
        return this.context.Examples.ToList();
    }

    public ExampleDTO? GetById(int identifier) {
        return this.context.Examples.Where(example => example.Id == identifier).First();
    }

    public ExampleDTO Create(ExampleDTO instance) {
        _ = this.context.Examples.Add(instance);
        _ = this.context.SaveChanges();
        return instance;
    }

    public ExampleDTO Update(ExampleDTO instance) {
        instance.DateUpdated = DateTime.Now;
        _ = this.context.Examples.Update(instance);
        _ = this.context.SaveChanges();
        return instance;
    }

    public ExampleDTO Delete(ExampleDTO instance) {
        instance.DateDeleted = DateTime.Now;
        _ = this.context.Examples.Remove(instance);
        _ = this.context.SaveChanges();
        return instance;
    }
}
