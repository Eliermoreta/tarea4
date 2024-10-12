public class MediaService
{
    private readonly ApplicationDbContext _context;

    public MediaService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddMediaItem(MediaItem mediaItem)
    {
        _context.MediaItems.Add(mediaItem);
        await _context.SaveChangesAsync();
    }

    public async Task<List<MediaItem>> GetMediaItems()
    {
        return await _context.MediaItems.ToListAsync();
    }
}