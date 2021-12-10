using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;
using WebAPI.Models;
using Xunit;

namespace XUnitProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "Student 1", "Email1", "Data inserted successfully")]
        [InlineData(2, "Student 2", "Email2", "Data inserted successfully")]
        [InlineData(3, "Student 3", "Email3", "Data inserted successfully")]
        [InlineData(4, "Student 4", "Email4", "Data inserted successfully")]
        public void Test1(int Id, string Name, string Email, string ExpectedResult)
        {
            Student objStudent = new Student();
            objStudent.Id = Id;
            objStudent.Name = Name;
            objStudent.Email = Email;

            StudentController objStudentController = new StudentController();

            ActionResult<string> actionResult = objStudentController.CreateStudent(objStudent);
            string result = actionResult.Value;
            Assert.Equal(ExpectedResult, result);

        }
    }
}
