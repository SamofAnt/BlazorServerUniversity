using Microsoft.EntityFrameworkCore;

namespace BlazorServerUniversity.Repositories;

public class PersonalDataRepository : IPersonalDataRepository
{
    private readonly UniversityContext _context;
    public PersonalDataRepository(UniversityContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task<PersonalDatum> GetById(long id) => await _context.PersonalData.FirstAsync(p => p.IdPersonalData == id);

    public async Task<IEnumerable<PersonalDatum>> GetAll() => await _context.PersonalData.ToListAsync();

    public async Task<PersonalDatum?> FindById(long id) => await _context.PersonalData.FirstOrDefaultAsync(p => p.IdPersonalData == id);

    public async Task Add(PersonalDatum entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(PersonalDatum entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task Remove(StudentInfo entity)
    {
        var studentToDelete = GetAll().Result.First(s => s.StudentId == entity.IdStudent);
        _context.Remove(studentToDelete);
        await _context.SaveChangesAsync();
    }
}