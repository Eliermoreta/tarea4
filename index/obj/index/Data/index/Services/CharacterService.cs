public class CharacterService
{
    private readonly ApplicationDbContext _context;

    public CharacterService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddCharacter(Personaje personaje)
    {
        _context.Personajes.Add(personaje);
        await _context.SaveChangesAsync();
    }
}