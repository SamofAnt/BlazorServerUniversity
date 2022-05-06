namespace BlazorServerUniversity.Repositories;

public interface IStudentRepository
{
    Task<Student> GetById(int id);
    Task<IEnumerable<StudentInfo>> GetAll();
    Task<Student?> FindById(int id);
    
    Task Add(Student entity);
    Task Update(Student entity);
    Task Remove(Student entity);
}