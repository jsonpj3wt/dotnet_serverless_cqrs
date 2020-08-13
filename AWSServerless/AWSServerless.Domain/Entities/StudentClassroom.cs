﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AWSServerless.Domain.Entities
{
    public class StudentClassroom
    {
        public int StudentId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        public int ClassRoomId { get; set; }

        [ForeignKey(nameof(ClassRoomId))]
        public Classroom Classroom { get; set; }
    }
}
