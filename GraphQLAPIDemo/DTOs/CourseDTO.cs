using GraphQLAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.DTOs
{
    public class CourseDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid InstructorId { get; set; }

        public InstructorDTO Instructor { get; set; }

        public Subject Subject { get; set; }

        public IEnumerable<StudentDTO> Student { get; set; }
    }
}
