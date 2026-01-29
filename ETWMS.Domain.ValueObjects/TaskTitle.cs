namespace ETWMS.Domain.ValueObjects
{
    public class TaskTitle
    {
        public string Value { get; private set; }

        public TaskTitle(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Task title cannot be empty.");

            Value = value;
        }

        // Equality check
        public override bool Equals(object? obj) => obj is TaskTitle other && Value == other.Value;
        public override int GetHashCode() => Value.GetHashCode();
    }
}
