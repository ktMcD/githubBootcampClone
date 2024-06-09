using MyWebApp.Models;

namespace MyWebApp
{
    public class StudentRepository
    {
        private List<StudentViewModel> _mockStudents;

        public StudentRepository()
        {
            CreateMockStudentList();
        }
        private void CreateMockStudentList()
        {
            _mockStudents = new List<StudentViewModel>();
            _mockStudents.Add(new StudentViewModel { Id = 1, Name = "Steve", Course = "AHBC C#", TechnicalExperience = "Neophyte", PreviousCourseCount = 5 });
            _mockStudents.Add(new StudentViewModel { Id = 2, Name = "Mary", Course = "AHBC C#", TechnicalExperience = "Master", PreviousCourseCount = 7 });
            _mockStudents.Add(new StudentViewModel { Id = 3, Name = "David", Course = "AHBC C#", TechnicalExperience = "Journeyman", PreviousCourseCount = 3 });
            _mockStudents.Add(new StudentViewModel { Id = 4, Name = "Kate", Course = "AHBC C#", TechnicalExperience = "Apprentice", PreviousCourseCount = 9 });
        }
        public IEnumerable<StudentViewModel> GetMockStudents()
        {
            return _mockStudents;
        }

        public void UpdateStudent(StudentViewModel student)
        {
            int index = _mockStudents.FindIndex(x => x.Id == student.Id);
            _mockStudents[index] = student;
        }

        public void DeleteStudent(int id)
        {
            int index = _mockStudents.FindIndex(x => x.Id == id);
            _mockStudents.RemoveAt(index);
        }
        public void CreateStudent(StudentViewModel student)
        {
            // get next student Id (I don't think we'd need this with a live DB)
            student.Id = _mockStudents.Max(x => x.Id) + 1;
            _mockStudents.Add(student);


        }
    }
}