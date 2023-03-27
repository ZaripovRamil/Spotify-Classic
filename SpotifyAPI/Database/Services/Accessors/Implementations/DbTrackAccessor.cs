﻿using Database.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Database.Services.Accessors.Implementations;

public class DbTrackAccessor : DbAccessor, IDbTrackAccessor
{
    public DbTrackAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Track track)
    {
        await DbContext.Tracks.AddAsync(track);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Track?> Get(string id)
    {
        return await DbContext.Tracks.FirstOrDefaultAsync(track => track.Id == id);
    }

    public IEnumerable<Track> GetAll()
    {
        return DbContext.Tracks.Include(t=>t.Album)
            .Include(t=>t.Album.Author)
            .Include(t=>t.Genres); 
    }
}