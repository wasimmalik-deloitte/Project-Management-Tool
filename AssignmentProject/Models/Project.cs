using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentProject.Models;

public class Project{
    
    
      [Key]
    public int projectid { get; set; }
    
   
    public String projectName { get; set; }

    public String projectDescription { get; set; }

    ///public User user{get; set;}

}
