using lesson3.Dl;
using lesson3.Model;

namespace lesson3.Bl
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public Tasks UpdateTasks(Tasks task)
        {
            _repository.UpdateTask(task);
            return task;
        }
        public Tasks createTask(Tasks task)
        {
            Tasks newTask = new Tasks();
            newTask.id = task.id;
            newTask.priority = task.priority;
            newTask.dueDate = task.dueDate;
            newTask.Status = task.Status;
            return _repository.CreateTask(newTask);
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _repository.GetAllTasks();
        }

        public IEnumerable<Tasks> Delete(int id)
        {
            IEnumerable<Tasks> tasks = _repository.GetAllTasks();
            Tasks task = tasks.FirstOrDefault(t => t.id == id);
            return _repository.Delete(task);

        }
    }
}
