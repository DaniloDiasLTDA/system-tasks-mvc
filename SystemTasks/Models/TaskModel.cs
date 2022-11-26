using System.Reflection.Metadata.Ecma335;
using SystemTasks.Enums;

namespace SystemTasks.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTask Status { get; set; }
    }
}
