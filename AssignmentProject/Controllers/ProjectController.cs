using AssignmentProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AssignmentProject.Models;

namespace AssignmentProject.Controllers;

[ApiController]
public class ProjectController:ControllerBase{
    IProjectService _projectService;
    public ProjectController(IProjectService service) {
        _projectService = service;
    }

    [HttpPost]
    [Route("[action]")]
    public IActionResult SaveProject(Project projectModel) {
        try {
            var model = _projectService.SaveProject(projectModel);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult GetAllProjectsList() {
        try {
            var projects = _projectService.GetAllProject();
            if (projects == null) return NotFound();
            return Ok(projects);
        } catch (Exception) {
            return BadRequest();
        }
    }


    [HttpGet]
    [Route("[action]/id")]
    public IActionResult GetProjectById(int id) {
        try {
            var proj = _projectService.GetProjectById(id);
            if (proj == null) return NotFound();
            return Ok(proj);
        } catch (Exception) {
            return BadRequest();
        }
    }

    [HttpDelete]
    [Route("[action]")]
    public IActionResult DeleteProject(int id) {
        try {
            var model = _projectService.DeleteProject(id);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }

}