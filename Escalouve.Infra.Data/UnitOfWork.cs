﻿using Escalouve.Domain.Interfaces;
using Escalouve.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Escalouve.Infra.Data
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _transaction.CommitAsync();
        }

        public async Task RollbackAsync()
        {
            await _transaction.RollbackAsync();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
        }
    }
}
