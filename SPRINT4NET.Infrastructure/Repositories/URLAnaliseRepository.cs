using SPRINT4NET.Domain.Entities;
using SPRINT4NET.Infrastructure.Data;
using SPRINT4NET.Application.Interfaces;


namespace SPRINT4NET.Infrastructure.Repositories
{
    public class URLAnaliseRepository : IURLAnaliseRepository
    {
        private readonly ApplicationDbContext _context;

        public URLAnaliseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<URLAnalise> GetByIdAsync(int id)
        {
            return await _context.URLAnalises.FindAsync(id);
        }

        public async Task AddAsync(URLAnalise urlAnalise)
        {
            await _context.URLAnalises.AddAsync(urlAnalise);
            await _context.SaveChangesAsync();
        }
    }
}