using lesson3.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;


namespace lesson3.Dl
{
    public class Repository : IRepository
    {
        private readonly TaskDbContext _context;
        public Repository(TaskDbContext context)
        {
            _context = context;
        }
        public void UpdateTask(Tasks task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
            
        }

        public Tasks CreateTask(Tasks task)
        {
            _context.Tasks.Add(task);
           
            _context.SaveChanges();
            return task;
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public IEnumerable<Tasks> Delete(Tasks task)
        {

            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return _context.Tasks.ToList();
        }
    }
}
