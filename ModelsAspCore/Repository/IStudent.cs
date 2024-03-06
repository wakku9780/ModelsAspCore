using ModelsAspCore.Models;

namespace ModelsAspCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
