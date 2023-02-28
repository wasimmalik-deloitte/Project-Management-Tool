using AssignmentProject.Models;

namespace AssignmentProject.Services;
public interface IProjectService
    {
      
       
      
        ResponseModel SaveProject(Project projectModel);


        List<Project> GetAllProject();

        Project GetProjectById(int Pid);

        ResponseModel DeleteProject(int Pid);


    
    }