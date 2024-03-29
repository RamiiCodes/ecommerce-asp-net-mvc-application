﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
           _context.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return  result;
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
