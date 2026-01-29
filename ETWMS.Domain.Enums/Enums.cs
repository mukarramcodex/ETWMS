namespace ETWMS.Domain.Enums
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Review,
        Completed,
        Rejected,
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High,
        Critical
    }

    public enum UserRole
    {
        Admin,
        Manager,
        Employee,
        Guest
    }
}
