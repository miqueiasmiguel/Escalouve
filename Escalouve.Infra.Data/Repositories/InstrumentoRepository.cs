using Escalouve.Domain.Entities;
using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalouve.Infra.Data.Repositories
{
    public class InstrumentoRepository : IRepository<Instrumento>
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

        public async Task<IEnumerable<Instrumento>> GetAllAsync()
        {
            return await _context.Instrumentos.ToListAsync();
        }

        public async Task<Instrumento?> GetByIdAsync(int id)
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
