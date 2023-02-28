using AssignmentProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AssignmentProject.Models;

namespace AssignmentProject.Controllers;

[ApiController]
public class UserController:ControllerBase{
    IUserService _userService;
    public UserController(IUserService service) {
        _userService = service;
    }

        /// <summary>
    /// get all employess
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]")]
    public IActionResult GetAllUsersList() {
        try {
            var user = _userService.GetUsersList();
            if (user == null) return NotFound();
            return Ok(user);
        } catch (Exception) {
            return BadRequest();
        }
    }

    /// <summary>
    /// get employee details by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("[action]/id")]
    public IActionResult GetUserById(int id) {
        try {
            var user = _userService.GetUserDetailsById(id);
            if (user == null) return NotFound();
            return Ok(user);
        } catch (Exception) {
            return BadRequest();
        }
    }
    
    /// <summary>
    /// save employee
    /// </summary>
    /// <param name="employeeModel"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("[action]")]
    public IActionResult SaveUser(User UserModel) {
        try {
            Console.WriteLine("insideCOntroller");
            var model = _userService.SaveUser(UserModel);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }

    /// <summary>
    /// delete employee
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("[action]")]
    public IActionResult DeleteUser(int id) {
        try {
            var model = _userService.DeleteUser(id);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }
}