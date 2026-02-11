using Student;

namespace DBOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository repo = new StudentRepository();
            StudentModel s1 = new StudentModel("Talal", "Ejaz", "03359378102", 309, 948, 1013);
            repo.Create(s1);
        }
    }
}