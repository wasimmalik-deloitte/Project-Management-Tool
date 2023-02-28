using System.ComponentModel.DataAnnotations;

namespace AssignmentProject.Models;

public class User{
    
    [Key]
    public int userid { get; set; }

    public String Name { get; set; }

    public String Email { get; set; }

    //collection
    ///public ICollection<Project> project {get; set;}


}
