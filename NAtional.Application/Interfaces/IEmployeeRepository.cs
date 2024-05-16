using National.Domen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Application.Interfaces;

public interface IEmployeeRepository
{
    public Task<Employee> GetEmployee(string guid);
}
