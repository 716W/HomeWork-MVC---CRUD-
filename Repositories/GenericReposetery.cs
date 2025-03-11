using HomeWork.Models;

namespace HomeWork.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : Student
    {
        private  static List<T>? _items;
        private static int idCount = 1 ;

        public GenericRepository()
        {
            _items = new List<T>();

            var st = new Student
            {
                Id = idCount ,
                FirstName = "Ahmed",
                LastName = "Ali",
                MajorName = "Computer Science",
                PhoneNumber = "123456789",
                Email = "ga@gmail.com",
                Address = "Cairo",
                Age = 20,
                GPA = 3.5
            };

            if (st is T studentT)
            {
                
                _items.Add(studentT);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T? GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(T item)
        {
            if (_items.Count == 0)
            {
                idCount = 1;
            }

            item.Id = idCount++;
            _items.Add(item);
        }

        public void Update(T item)
        {
            var existingItem = GetById(item.Id);

            if (existingItem != null)
            {
                _items.Remove(existingItem);
                _items.Add(item);
            }
        }

        public void Delete(int id)
        {
            var exist = GetById(id);
            if (exist != null)
            {
                _items.Remove(exist);
            }
        }
    }
}
