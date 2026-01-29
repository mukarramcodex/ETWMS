using ETWMS.Domain.Enums;

namespace ETWMS.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public UserRole Role { get; private set; }

        public List<Task> Tasks { get; private set; } = new();

        public User(string fullName, string email, UserRole role)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Email = email;
            Role = role;
        }

        public void AssignTask(Task task)
        {
            if (!Tasks.Contains(task))
                Tasks.Add(task);
        }
    }
}
