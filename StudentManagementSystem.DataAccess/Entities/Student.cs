﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DataAccess.Entities
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual string Dept { get; set; }
    }
}
