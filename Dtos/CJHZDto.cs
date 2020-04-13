using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    /// <summary>
    /// 成绩汇总
    /// </summary>
    public class CJHZDto
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public double Zycj { get; set; }
        public double Sycj { get; set; }
        public double Kscj1 { get; set; }
        public double Kscj2 { get; set; }
        public double Kscj3 { get; set; }
        public double Kscj4 { get; set; }
        public double Kscj5 { get; set; }
        public double Cj { get; set; }
        public virtual PeCourse Course { get; set; } 
        public double FinalGrade
        {
            get
            {
                var v = (Course.Psycj * Sycj / 100) +
                    (Course.Pzycj * Zycj / 100) +
                    (Course.Pkscj1 * Kscj1 / 100) +
                    (Course.Pkscj2 * Kscj2 / 100) +
                    (Course.Pkscj3 * Kscj3 / 100) +
                    (Course.Pkscj4 * Kscj4 / 100) +
                    (Course.Pkscj5 * Kscj5 / 100);
                return Math.Round(v);
            }
        }
        public string Level
        {
            get
            {
                if (FinalGrade >= 90)
                {
                    return "优秀";
                }
                else if (FinalGrade >= 80 && FinalGrade <= 89)
                {
                    return "良好";
                }
                else if (FinalGrade >= 70 && FinalGrade <= 79)
                {
                    return "中等";
                }
                else if (FinalGrade >= 60 && FinalGrade <= 69)
                {
                    return "及格";
                }
                else if (FinalGrade >= 40 && FinalGrade <= 59)
                {
                    return "不及格";
                }
                else
                {
                    return "缓考";
                }
            }
        }
    }
}
