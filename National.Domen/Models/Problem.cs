using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National.Domen.Models;

public class Problem
{
    public int Id { get; set; }
    public int? ProjectId { get; set; }
    public Project Project { get; set; }
    public string FullTitle { get; set; } = null!;
    public string ShortTitle { get; set; } = null!;
    public string? Discription { get; set; } = null!;
    public string? DirectorEmployeeId { get; set; }
    public string? ExecutiveEmployeeId { get; set; }
    public string? WatcherEmployeeId { get; set; }
    public int StatusId { get; set; }
    public Status? Status { get; set; }
    public DateTime CreatedTime { get; set; } = DateTime.Now;
    public DateTime? UpdateTime { get; set; }
    public DateTime? DeletedTime { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime StartFinishTime { get; set; } = DateTime.Now;
    public DateTime? FinishFinishTime { get; set; }

    public int? PreviousTaskId { get; set; }

    public IEnumerable<CommentOnTask>? CommentOnTask { get; set; }
}
