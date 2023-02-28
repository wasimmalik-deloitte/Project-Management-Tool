using AssignmentProject;
using AssignmentProject.Models;
using AssignmentProject.Services;
using Microsoft.EntityFrameworkCore;



public class IssueService: IissueService
{
    private UserContext _context;

    public IssueService(UserContext context)
    {
        _context = context;
    }

    //CRUD OPERATIONS
    //ADDITION OF EMPLOYEE
  

    public ResponseModel SaveIssue(Issue IssueModel)
        {
        ResponseModel model = new ResponseModel();
        try {
                Issue issue = new Issue(){
                    
                    IssueName = IssueModel.IssueName,
                    IssueDetails = IssueModel.IssueDetails

                };
                _context.Add < Issue > (issue);
                model.Message = "Issue Inserted Successfully";
           // }
            _context.SaveChanges();
            model.IsSuccess = true;
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }

    
    public Issue GetIssueById(int IssueId)
    {
        Issue issue;
        try {
            issue = _context.Find < Issue > (IssueId);
        } catch (Exception) {
            throw;
        }
        return issue;

    }
    
    public List<Issue> GetAllIssues(){
        List < Issue > IssueList;
        try {
            IssueList = _context.issues.ToList();
        } catch (Exception) {
            throw;
        }
        return IssueList;
    }
    


    public ResponseModel DeleteIssue(int IssueId)
    {
        ResponseModel model = new ResponseModel();
        try {
            Issue _temp = GetIssueById(IssueId);
            if (_temp != null) {
                _context.Remove < Issue > (_temp);
                _context.SaveChanges();
                model.IsSuccess = true;
                model.Message = "Issue Deleted Successfully";
            } else {
                model.IsSuccess = false;
                model.Message = "Issue Not Found";
            }
        } catch (Exception ex) {
            model.IsSuccess = false;
            model.Message = "Error : " + ex.Message;
        }
        return model;
    }

    
}