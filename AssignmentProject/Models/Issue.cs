using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentProject.Models;

public class Issue{

    [Key]
    public int IssueId { get; set; }

    public String IssueName { get; set; }

    public String IssueDetails { get; set; }

}