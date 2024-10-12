using StudentManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Cfg;

namespace StudentManagementSystem.DataAccess.Mappings
{
    public class StudentMapping : ClassMap<Student>
    {
        public StudentMapping()
        {
            Table("Student");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.Age);
            Map(x => x.Dept);
        }
    }
}
