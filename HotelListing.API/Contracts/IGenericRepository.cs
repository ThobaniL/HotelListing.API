﻿namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T rntity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
    }
}
