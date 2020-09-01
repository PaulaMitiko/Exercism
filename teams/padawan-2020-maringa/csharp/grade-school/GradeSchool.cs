using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly List<StudentGrade> SchoolStudents = new List<StudentGrade>();
    private class StudentGrade 
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    public void Add(string student, int grade)
    {
        SchoolStudents.Add(
            new StudentGrade
            {
                Name = student,
                Grade = grade
            });
    }
    public IEnumerable<string> Roster()
    {
        var allSchoolStudents = new List<string>();
        if (SchoolStudents.Any())
        {
            for (int i = 1; i <= SchoolStudents.Max(q => q.Grade); i++)
            {
                allSchoolStudents.AddRange(Grade(i));
            }
        }
        return allSchoolStudents;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var gradeStudents = new List<string>();
        foreach (var student in SchoolStudents) 
        {
            if (student.Grade == grade) gradeStudents.Add(student.Name);
        }
        return gradeStudents.OrderBy(q => q);
    }
}