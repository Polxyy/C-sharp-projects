using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krsova
{
    public class Patient
    {
        public static List<Patient> patients = new List<Patient>();
        public static string filePath = "patients.txt";
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateOfExamination { get; set; }
    }
}
