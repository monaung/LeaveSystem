namespace HR.LeaveManagement.Domain
{
    public class LeaveAllocation : BasedEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }

        public string EmployeeId { get; set; } = string.Empty;
    }
}
