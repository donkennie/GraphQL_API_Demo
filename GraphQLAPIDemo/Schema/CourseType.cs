using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.Schema
{

    public enum Subject
    {
        Mathematics,
        Science,
        History
    }

    public class CourseType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        [GraphQLNonNullType]
        public InstructorType Instructor { get; set; }

        public Subject Subject { get; set; }

       // [IsProjected(true)]
        public IEnumerable<StudentType> Student{ get; set; }

        public string Description() 
        {
            return $"{Name}This is a description";
        }
    }
}
