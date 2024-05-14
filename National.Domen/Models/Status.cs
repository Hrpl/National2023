using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Domen.Models;

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ColoeHex { get; set; }

    public IEnumerable<Problem>? Tasks { get; set; }
}
