﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
    public class SearchStudent : Search
    {
        public List<Student> ListedStudents { get; private set; }
    }
}