using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Escalouve.Infra.Data.Repositories
{
    public class InstrumentoRepository : IInstrumentoRepository
    {
        ApplicationDbContext _context;

        public InstrumentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Instrumento> CreateAsync(Instrumento entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Instrumento> DeleteAsync(Instrumento entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Existe(int id)
        {
            return await _context.Instrumentos.AnyAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Instrumento>> GetAllAsync()
        {
            return await _context.Instrumentos.ToListAsync();
        }

        public async Task<Instrumento?> GetByIdAsync(int? id)
        {
            return await _context.Instrumentos.FindAsync(id);
        }

        public async Task<Instrumento> UpdateAsync(Instrumento entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
