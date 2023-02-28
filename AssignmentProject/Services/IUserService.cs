using AssignmentProject.Models;

namespace AssignmentProject.Services;
public interface IUserService
    {
      
        List<User> GetUsersList();

    
        User GetUserDetailsById(int userId);

      
        ResponseModel SaveUser(User userModel);


        ResponseModel DeleteUser(int userid);
    
    }