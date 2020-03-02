using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class CourseDto
    {
        //课程ID
        public int Id { get; set; }
        //课程名称
        public string  Name { get; set; }
        //课程简介
        public string Intro { get; set; }
        //课程logo
        public string Logo { get; set; }
    }
}
