using National.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using National.Domen.Models;
using National.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace National.Application.Services;

public class TaskRepository : ITaskRepository
{
    private readonly NatProjDbContext _db;

    public TaskRepository(NatProjDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Problem>> GetAllProblemAsync()
    {
        return await _db.Problems.ToListAsync();
    }

    public async Task<IEnumerable<Problem>> GetAnyProblemAsync(string shortName)
    {
        return await _db.Problems.Where(t => t.ShortTitle.Contains(shortName)).Include(u => u.Status).ToListAsync();
    }
}
