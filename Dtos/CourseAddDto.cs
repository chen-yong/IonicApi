using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class CourseAddDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Teacher { get; set; }
        public int? Teacher1 { get; set; }
        public int? Teacher2 { get; set; }
        public int? Teacher3 { get; set; }
        public string Intro { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? ModuleKownledge { get; set; }
        public bool? ModuleResource { get; set; }
        public bool? ModuleHomework { get; set; }
        public bool? ModuleMutualJudge { get; set; }
        public bool? ModuleExperiment { get; set; }
        public bool? ModuleSimulation { get; set; }
        public bool? ModuleDiscuss { get; set; }
        public string Logo1 { get; set; }
        public string LogoText { get; set; }
        public string LogoBackgroundColor { get; set; }
        public bool IsDel { get; set; }
        public bool? IsBan { get; set; }
        public int Status { get; set; }
        public int? Ord { get; set; }
        public double Pzycj { get; set; }
        public double Psycj { get; set; }
        public double Pkscj1 { get; set; }
        public double Pkscj2 { get; set; }
        public double Pkscj3 { get; set; }
        public double Pkscj4 { get; set; }
        public double Pkscj5 { get; set; }
        public bool IsAuthor { get; set; }
        public int CopyTimes { get; set; }
    }
}
