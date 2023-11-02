namespace _420DA3_07451_Projet_Initial.DataAccess.Abstracts;
public interface IDao<DtoType, DtoIdType> where DtoType : class, IDto<DtoIdType> {

    public List<DtoType> GetAll();

    public DtoType? GetById(DtoIdType identifier);

    public DtoType Create(DtoType instance);

    public DtoType Update(DtoType instance);

    public DtoType Delete(DtoType instance);

}
