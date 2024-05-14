using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Domen.Models;

public class CommentOnTask
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    
    public int TaskId { get; set; }
    public Problem? Task { get; set; }

    public string Comment { get; set; }
}
