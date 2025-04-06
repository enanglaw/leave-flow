public class LeaveAllocation
{
    public int Id { get; set; }

    public int LeaveTypeId { get; set; }

    public int NumberOfDays { get; set; }
    public int Year { get; set; }
    public int StaffId { get; set; }
    public Staff Staff { get; set; }
    public LeaveType LeaveType { get; set; }
}