using AssignmentProject;
using AssignmentProject.Models;
using AssignmentProject.Services;
using Microsoft.EntityFrameworkCore;



public class UserService: IUserService
{
    private UserContext _context;

    public UserService(UserContext context)
    {
        _context = context;
    }

    //CRUD OPERATIONS
    //ADDITION OF EMPLOYEE
    
    public ResponseModel SaveUser(User UserModel)
        {
        ResponseModel model = new ResponseModel();
        try {
                User usr = new User(){
                    Name = UserModel.Name,
                    Email = UserModel.Email
                };
                _context.Add < User > (usr);
                model.Message = "User Inserted Successfully";
           // }
            _context.SaveChanges();
            model.IsSuccess = true;
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }

    public User GetUserDetailsById(int userid)
    {
        User usr;
        try {
            usr = _context.Find < User > (userid);
        } catch (Exception) {
            throw;
        }
        return usr;

    }

    public List<User> GetUsersList(){
        List < User > UserList;
        try {
            UserList = _context.Users.ToList();
        } catch (Exception) {
            throw;
        }
        return UserList;
    }

    public ResponseModel DeleteUser(int UserId)
    {
        ResponseModel model = new ResponseModel();
        try {
            User _temp = GetUserDetailsById(UserId);
            if (_temp != null) {
                _context.Remove < User > (_temp);
                _context.SaveChanges();
                model.IsSuccess = true;
                model.Message = "User Deleted Successfully";
            } else {
                model.IsSuccess = false;
                model.Message = "User Not Found";
            }
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }




    


}