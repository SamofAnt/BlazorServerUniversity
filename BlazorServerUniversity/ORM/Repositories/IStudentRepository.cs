namespace BlazorServerUniversity.Repositories;

public interface IStudentRepository
{
    Task<Student> GetById(int id);
    Task<IEnumerable<Student>> GetAll();
    Task<IEnumerable<StudentInfo>> GetAllWithInfo();
    Task<IEnumerable<StudentInfo>> GetAllByGroup();

    Task<Student?> FindById(int id);
    Task<IEnumerable<StudentInfo?>> GetAllDisciplines(int id);
    
    Task Add(Student entity);
    Task Update(Student entity);
    Task Remove(Student entity);
}