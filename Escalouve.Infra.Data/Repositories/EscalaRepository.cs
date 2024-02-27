using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Escalouve.Infra.Data.Repositories
{
    public class EscalaRepository : IRepository<Escala>
    {
        ApplicationDbContext _context;

        public EscalaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Escala> CreateAsync(Escala entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Escala> DeleteAsync(Escala entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Escala>> GetAllAsync()
        {
            return await _context.Escalas.ToListAsync();
        }

        public async Task<Escala?> GetByIdAsync(int id)
        {
            return await _context.Escalas.FindAsync(id);
        }

        public async Task<Escala> UpdateAsync(Escala entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
