using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ToDoTask
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; } = "New Task";

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public DateTime ExecutionDate { get; set;}

        public int AfterDeadLine { get; set;}
    }
}