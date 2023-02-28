using AssignmentProject.Models;

namespace AssignmentProject.Services;
public interface IissueService
{
    ResponseModel SaveIssue(Issue projectModel);


    List<Issue> GetAllIssues();

    Issue GetIssueById(int IssueId);

    ResponseModel DeleteIssue(int IssueId);
}