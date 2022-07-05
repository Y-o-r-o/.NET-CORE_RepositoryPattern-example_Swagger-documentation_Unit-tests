﻿using RepositoryLayer.Databases.Configuration;
using RepositoryLayer.Databases.Entities;
using RepositoryLayer.Repositories.Base;

namespace RepositoryLayer.Repositories;
internal class RefreshTokenRepository : ContextRepositoryBase<RefreshToken>, IRefreshTokenRepository
{

    public RefreshTokenRepository(DataContext context) : base(context)
    {
        Entities = context.Set<RefreshToken>();
    }

    public async Task<RefreshToken?> GetRefreshTokenByRequestRefreshToken(string requestRefreshToken)
        => await GetAsync(t => t.Token == requestRefreshToken);

    public async Task RemoveRefreshToken(RefreshToken refreshToken)
        => await RemoveAsync(refreshToken);

    public async Task AddRefreshToken(string refreshToken, string userId)
        => await RemoveAsync(new RefreshToken() { UserId = userId, Token = refreshToken });

}