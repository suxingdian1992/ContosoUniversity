using System.Collections.Generic;
using ContosoUniversity.Models;

/// <summary>
/// 这是一个视图类，集合了相关的三项属性
/// </summary>
namespace ContosoUniversity.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}