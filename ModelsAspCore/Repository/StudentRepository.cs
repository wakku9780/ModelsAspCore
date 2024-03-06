using ModelsAspCore.Models;
using System.Reflection;
using System.Xml.Linq;

namespace ModelsAspCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                 
            
                new StudentModel{rollNo=1,Name ="Waqar",Gender="Male",Standard=11},
                new StudentModel{rollNo=2,Name ="Abdul",Gender="Male",Standard=11},
                new StudentModel{rollNo=3,Name ="Tania",Gender="Female",Standard=11},
                new StudentModel{rollNo=4,Name ="Kaveri",Gender="Female",Standard=10},
                new StudentModel{rollNo=5,Name ="Hashim",Gender="Male",Standard=10},
            };
        

        }
    }
}
