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

        public async Task<Instrumento> Create(Instrumento entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Instrumento> Delete(Instrumento entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Instrumento>> GetAll()
        {
            return await _context.Instrumentos.ToListAsync();
        }

        public async Task<Instrumento?> GetById(int id)
        {
            return await _context.Instrumentos.FindAsync(id);
        }

        public async Task<Instrumento> Update(Instrumento entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
