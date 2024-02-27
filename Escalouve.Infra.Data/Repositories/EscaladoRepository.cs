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
    public class EscaladoRepository : IRepository<Escalado>
    {
        ApplicationDbContext _context;

        public EscaladoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Escalado> Create(Escalado entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Escalado> Delete(Escalado entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Escalado>> GetAll()
        {
            return await _context.Escalados.ToListAsync();
        }

        public async Task<Escalado?> GetById(int id)
        {
            return await _context.Escalados.FindAsync(id);
        }

        public async Task<Escalado> Update(Escalado entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
