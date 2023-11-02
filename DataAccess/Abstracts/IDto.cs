namespace _420DA3_07451_Projet_Initial.DataAccess.Abstracts;

public interface IDto {

}

public interface IDto<DtoIdType> : IDto {

    public DtoIdType? GetId();

}
