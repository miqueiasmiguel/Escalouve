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
    public class EscalaRepository : IRepository<Escala>
    {
        ApplicationDbContext _context;

        public EscalaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Escala> Create(Escala entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Escala> Delete(Escala entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Escala>> GetAll()
        {
            return await _context.Escalas.ToListAsync();
        }

        public async Task<Escala?> GetById(int id)
        {
            return await _context.Escalas.FindAsync(id);
        }

        public async Task<Escala> Update(Escala entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
