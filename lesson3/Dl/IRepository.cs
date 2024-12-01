using lesson3.Model;

namespace lesson3.Dl
{
    public interface IRepository
    {
        void UpdateTask(Tasks tasks);
        Tasks CreateTask(Tasks task);
        IEnumerable<Tasks> GetAllTasks();
        IEnumerable<Tasks> Delete(Tasks task);
       
    }
}