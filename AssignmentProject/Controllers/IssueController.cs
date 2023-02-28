using AssignmentProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AssignmentProject.Models;

namespace AssignmentProject.Controllers;

[ApiController]
public class IssueController:ControllerBase{
    IissueService _issueService;
    public IssueController(IissueService service) {
        _issueService = service;
    }


    [HttpPost]
    [Route("[action]")]
    public IActionResult saveIssue(Issue issueModel) {
        try {
            var model = _issueService.SaveIssue(issueModel);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult GetAllIssueList() {
        try {
            var issues = _issueService.GetAllIssues();
            if (issues == null) return NotFound();
            return Ok(issues);
        } catch (Exception) {
            return BadRequest();
        }
    }

    [HttpGet]
    [Route("[action]/id")]
    public IActionResult getIssueById(int id) {
        try {
            var proj = _issueService.GetIssueById(id);
            if (proj == null) return NotFound();
            return Ok(proj);
        } catch (Exception) {
            return BadRequest();
        }
    }

    [HttpDelete]
    [Route("[action]")]
    public IActionResult deleteIssue(int id) {
        try {
            var model = _issueService.DeleteIssue(id);
            return Ok(model);
        } catch (Exception) {
            return BadRequest();
        }
    }



}