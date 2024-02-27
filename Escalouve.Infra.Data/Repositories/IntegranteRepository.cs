using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Escalouve.Infra.Data.Repositories
{
    public class IntegranteRepository : IRepository<Integrante>
    {
        ApplicationDbContext _context;

        public IntegranteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Integrante> CreateAsync(Integrante entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Integrante> DeleteAsync(Integrante entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Integrante>> GetAllAsync()
        {
            return await _context.Integrantes.ToListAsync();
        }

        public async Task<Integrante?> GetByIdAsync(int id)
        {
            return await _context.Integrantes.FindAsync(id);
        }

        public async Task<Integrante> UpdateAsync(Integrante entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
