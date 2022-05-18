namespace BlazorServerUniversity.Repositories;

public interface IPersonalDataRepository
{
    Task<PersonalDatum> GetById(long id);
    Task<IEnumerable<PersonalDatum>> GetAll();
    Task<PersonalDatum?> FindById(long id);
    
    Task Add(PersonalDatum entity);
    Task Update(PersonalDatum entity);
    Task Remove(StudentInfo entity);
}