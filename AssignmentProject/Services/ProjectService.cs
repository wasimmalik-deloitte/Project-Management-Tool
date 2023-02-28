using AssignmentProject;
using AssignmentProject.Models;
using AssignmentProject.Services;
using Microsoft.EntityFrameworkCore;


/*
  List<user> GetProjectList();

    
        user GetProjectDetailsById(int userId);

      
        ResponseModel SavePorject(user userModel);


        ResponseModel DeleteProject(int userid);
    
*/

public class ProjectService : IProjectService
{
    private UserContext _context;
    public ProjectService(UserContext context)
    {
        _context = context;
    }


    public ResponseModel SaveProject(Project projectModel){
            ResponseModel model = new ResponseModel();
        try {
                Project proj = new Project(){
                    projectName = projectModel.projectName,
                    projectDescription = projectModel.projectDescription,
                    projectid = projectModel.projectid,
                    ///userid = projectModel.userid
                };
                _context.Add < Project > (proj);
                model.Message = "Project Inserted Successfully";
           // }
            _context.SaveChanges();
            model.IsSuccess = true;
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }

    public List<Project> GetAllProject(){
        List < Project > projectList;
        try {
            projectList = _context.projects.ToList();
        } catch (Exception) {
            throw;
        }
        return projectList;
    }

    public Project GetProjectById(int Pid){
        Project proj;
        try {
            proj = _context.Find < Project > (Pid);
        } catch (Exception) {
            throw;
        }
        return proj;
    }

    public ResponseModel DeleteProject(int Pid){
        ResponseModel model = new ResponseModel();
        try {
            Project _temp = GetProjectById(Pid);
            if (_temp != null) {
                _context.Remove < Project > (_temp);
                _context.SaveChanges();
                model.IsSuccess = true;
                model.Message = "project Deleted Successfully";
            } else {
                model.IsSuccess = false;
                model.Message = "Project Not Found";
            }
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }



}
    /*

    ResponseModel IProjectService.SaveProject(project projectModel)
    {
        throw new NotImplementedException();
    }
    */






    /*
    List<user> GetProjectList(){

    }


    user GetProjectDetailsById(int projectid){

    }


    ResponseModel DeleteProject(int projectid){

    }
    */


