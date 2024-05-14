using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Domen.Models;

public class Project
{
    public int Id { get; set; }
    public string Guid { get; set; } = null!;
    public string FullTitle { get; set; } = null!;
    public string ShortTitle { get; set; } = null!;
    public string Icon { get; set; } = null!;
    public DateTime CreatedTime { get; set; } = DateTime.Now;
    public DateTime? DeletedTime { get; set; }
    public DateTime StartSheduleDate { get; set; }
    public DateTime? FinishSheduleDate { get; set; }
    public string Discription { get; set; } = null!;
    public string CreatorEmployeeId { get; set; }
    public string ResponsibleEmployeeNameId { get; set; }

    public IEnumerable<Problem>? Tasks { get; set; }
}
