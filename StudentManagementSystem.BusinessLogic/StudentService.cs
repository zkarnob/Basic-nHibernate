using System.Collections.Generic;
using System.Linq;
using StudentManagementSystem.DataAccess.Entities;
using StudentManagementSystem.DataAccess;
using NHibernate;
using FluentNHibernate.Cfg;
namespace StudentManagementSystem.BusinessLogic

{
    public class StudentService
    {
        public void AddStudent(string name, int age, string dept)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var student = new Student
                    {
                        Name = name,
                        Age = age,
                        Dept = dept
                    };
                    session.Save(student);
                    transaction.Commit();
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var session = SessionFactory.OpenSession())
            {
                return session.Query<Student>().ToList();
            }
        }
    }
}
