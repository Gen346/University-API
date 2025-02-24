using API_practice_2.Data;

namespace API_practice_2.Repositories
{
    public class StudentRepository
    {
        //Singleton instance for 1 object
        private static StudentRepository? _instance;

        //Thread lock will guarantee that 1 instance will use 1 thread per scope.
        private static readonly object _lock = new object();

        private readonly ApplicationDBContext _context;

        private StudentRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public static StudentRepository GetInstance(ApplicationDBContext context)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if ( _instance == null)
                    {
                        _instance = new StudentRepository(context);
                    }
                }
            }
            return _instance;
        }
        //EF add new student
        public void AddNewStudent(Models.Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
