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
    public class IntegranteRepository : IRepository<Integrante>
    {
        ApplicationDbContext _context;

        public IntegranteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Integrante> Create(Integrante entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Integrante> Delete(Integrante entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Integrante>> GetAll()
        {
            return await _context.Integrantes.ToListAsync();
        }

        public async Task<Integrante?> GetById(int id)
        {
            return await _context.Integrantes.FindAsync(id);
        }

        public async Task<Integrante> Update(Integrante entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
