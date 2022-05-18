using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerUniversity.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly UniversityContext _context;
    public StudentRepository(UniversityContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));
    public async Task<Student> GetById(long id) => await _context.Students.FirstAsync(s => s.IdStudent == id);

    public async Task<IEnumerable<Student>> GetAll() => await _context.Students.ToListAsync();
    public async Task<IEnumerable<StudentInfo>> GetAllWithInfo() =>
        await (from s in _context.Students
            join pd in _context.PersonalData on s.IdStudent equals pd.StudentId
            join g in _context.Groups on s.GroupId equals g.IdGroup
            select new StudentInfo()
            {
                IdStudent = s.IdStudent,
                FirstName = pd.FirstName,
                LastName = pd.LastName,
                Age = pd.Age,
                Address = pd.Address,
                GroupName = g.Name,
                isStudy = s.IsStudy
            }).ToListAsync();

    public async Task<IEnumerable<StudentInfo>> GetAllByGroup() =>
        await (from s in _context.Students
            join pd in _context.PersonalData on s.IdStudent equals pd.StudentId
            join g in _context.Groups on s.GroupId equals g.IdGroup
            orderby g.Name, pd.LastName
            select new StudentInfo()
            {
                IdStudent = s.IdStudent,
                FirstName = pd.FirstName,
                LastName = pd.LastName,
                Age = pd.Age,
                Address = pd.Address,
                GroupName = g.Name,
                isStudy = s.IsStudy
            }).ToListAsync();

    public async Task<Student?> FindById(int id) => await _context.Students.FirstOrDefaultAsync(s => s.IdStudent == id);

    public async Task<IEnumerable<StudentInfo?>> GetAllDisciplines(int id) =>
        await (from s in _context.Students
            join sd in _context.StudentDisciplines on s.IdStudent equals sd.StudentId
            join d in _context.Disciplines on sd.DisciplineId equals d.IdDiscipline
            where sd.StudentId == id
            select new StudentInfo()
            {
                IdStudent = sd.StudentId,
                IdDiscipline = sd.DisciplineId,
                Grade = sd.Grade,
                DisciplineName = d.Name
            }).ToListAsync();

    public async Task Add(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task Remove(Student student)
    {
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
    }
}