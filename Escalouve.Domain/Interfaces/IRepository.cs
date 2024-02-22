﻿namespace Escalouve.Domain.Interfaces;

public interface IRepository<T>
{
    Task<T> Create(T entity);
    Task<IEnnumerable> GetAll();
    Task<T> GetById(int id);
    Task<T> Update(T entity);
    Task<T> Delete (T entity);
}
