using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ePizza.Domain.Interfaces;
using ePizza.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ePizza.Infrastructure.Repositories;

public class GenericRepository<TDomain, TEntity> : IGenericRepository<TDomain> 
where TDomain : class
where TEntity : class
{
    protected readonly EPizzaDbContext _dbContext;
    private readonly IMapper _mapper;
    public GenericRepository(EPizzaDbContext dbContext,IMapper mapper)
    {
        _dbContext = dbContext;
        this._mapper = mapper;
    }     

        public async Task<IEnumerable<TDomain>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>()
                .ProjectTo<TDomain>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
}
