using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaatashalaApi.DTOs;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        public readonly WebSchoolContext db;
        public HomeworkController(WebSchoolContext _db)
        {
            db = _db;
        }
        
        private DateTime ConvertToDateTime(string input)
        {
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                return dateTime;
            }
            return DateTime.Now;
        }
        private string ConvertToJavascriptDate(DateTime dateTime)
        {
            return dateTime.ToString("ddd MMM dd yyyy HH:mm:ss") + " GMT+0530";
        }
        [HttpGet("GetByCourse")]
        public async Task<JsonResult> GetByCourse(long CourseId, long BatchId, long OrgId)
        {
            try
            {

                {
                    var dateAndTime = DateTime.Now;
                    var date = dateAndTime.Date;
                    var HomeworkDetail = await (from tableAssignments in db.TblAssignments
                                                join tableAssignmentQuestion in db.TblAssignmentQuestions on tableAssignments.Id equals tableAssignmentQuestion.AssignmentId
                                                join tableSubjects in db.TblSubjects on tableAssignments.SubjectId equals tableSubjects.Id
                                                where tableAssignments.CourseId == CourseId && tableAssignments.BatchId == BatchId && tableAssignments.OrgId == OrgId && tableAssignments.DateOfAssignment == date
                                                select new { tableAssignments.Id, SubjectId = tableSubjects.Id, tableSubjects.Name, tableAssignments.DateOfAssignment, tableAssignments.AssignmentName, tableAssignmentQuestion.Question })
                                           .ToListAsync();

                    Homework Homeworkobj = new Homework();
                    Homeworkobj.assignmentsList = new List<Assignments>();
                    foreach (var temp in HomeworkDetail)
                    {
                        var Questiontemp = new Questions();
                        var HomeTemp = new Assignments
                        {
                            AssignmentId = temp.Id,
                            SubjectId = temp.SubjectId,
                            SubjectName = temp.Name,
                            AssignmentName = temp.AssignmentName,
                            Date = temp.DateOfAssignment.ToString("yyyy-MM-dd")
                        };

                        if (Homeworkobj.assignmentsList.Any(x => x.SubjectId == temp.SubjectId))
                        {
                            var stuobj = Homeworkobj.assignmentsList.Single(x => x.SubjectId == temp.SubjectId);
                            Questiontemp.QuestionsName = temp.Question;
                            stuobj.MultipleQuestion.Add(Questiontemp);
                        }
                        else
                        {
                            Questiontemp.QuestionsName = temp.Question;
                            HomeTemp.MultipleQuestion = new List<Questions> { Questiontemp };
                            Homeworkobj.assignmentsList.Add(HomeTemp);
                        }
                    }

                    return new JsonResult(Homeworkobj);
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
        [HttpGet("GetByDate")]
        public async Task<JsonResult> GetByDate(string Date, long OrgId, long CourseId, long BatchId)
        {
            try
            {

                var datee = ConvertToDateTime(Date);
                DateTime HWDate = new DateTime(datee.Year, datee.Month, datee.Day);
                var Assign = await (from tableassignment in db.TblAssignments
                                    join tableAssignQuestions in db.TblAssignmentQuestions on tableassignment.Id equals tableAssignQuestions.AssignmentId
                                    join tableSubject in db.TblSubjects on tableassignment.SubjectId equals tableSubject.Id
                                    where tableassignment.OrgId == OrgId && tableassignment.CourseId == CourseId && tableassignment.BatchId == BatchId &&
                                          tableassignment.DateOfAssignment == HWDate
                                    select new { tableAssignQuestions.Question, SubjectId = tableSubject.Id, tableSubject.Name, tableassignment.AssignmentName, tableassignment.DateOfAssignment })
                                    .ToListAsync();

                Homework Homeworkobj = new Homework();
                Homeworkobj.assignmentsList = new List<Assignments>();
                foreach (var temp in Assign)
                {
                    var Questiontemp = new Questions();
                    var HomeTemp = new Assignments
                    {
                        SubjectId = temp.SubjectId,
                        SubjectName = temp.Name,
                        AssignmentName = temp.AssignmentName,
                        Date = temp.DateOfAssignment.ToString("yyyy-MM-dd")
                    };

                    if (Homeworkobj.assignmentsList.Any(x => x.SubjectId == temp.SubjectId))
                    {
                        var stuobj = Homeworkobj.assignmentsList.Single(x => x.SubjectId == temp.SubjectId);
                        Questiontemp.QuestionsName = temp.Question;
                        stuobj.MultipleQuestion.Add(Questiontemp);
                    }
                    else
                    {
                        Questiontemp.QuestionsName = temp.Question;
                        HomeTemp.MultipleQuestion = new List<Questions> { Questiontemp };
                        Homeworkobj.assignmentsList.Add(HomeTemp);
                    }
                }

                return new JsonResult(Homeworkobj);
            }
            catch (Exception ex)
            {

                return new JsonResult(500, new { status = false, message = ex.ToString() });
            }
        }
    }
}
