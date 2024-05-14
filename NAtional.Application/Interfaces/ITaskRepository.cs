using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using National.Domen.Models;

namespace National.Application.Interfaces;

public interface ITaskRepository
{
    public Task<IEnumerable<Problem>> GetAllProblemAsync();
    public Task<IEnumerable<Problem>> GetAnyProblemAsync(string shortName);
}
