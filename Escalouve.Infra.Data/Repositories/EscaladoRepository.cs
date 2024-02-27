using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Escalouve.Infra.Data.Repositories
{
    public class EscaladoRepository : IRepository<Escalado>
    {
        ApplicationDbContext _context;

        public EscaladoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Escalado> CreateAsync(Escalado entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Escalado> DeleteAsync(Escalado entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Escalado>> GetAllAsync()
        {
            return await _context.Escalados.ToListAsync();
        }

        public async Task<Escalado?> GetByIdAsync(int id)
        {
            return await _context.Escalados.FindAsync(id);
        }

        public async Task<Escalado> UpdateAsync(Escalado entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
