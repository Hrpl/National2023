using Microsoft.EntityFrameworkCore;
using National.Application.Interfaces;
using National.Domen.Models;
using National.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Application.Services;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly NatProjDbContext _db;

    public EmployeeRepository(NatProjDbContext db)
    {
        _db = db;
    }

    public async Task<Employee> GetEmployee(string guid)
    {
        var emp = await _db.Employees.Where(e => e.Guid == guid).FirstOrDefaultAsync();
        return emp;
    }
}
