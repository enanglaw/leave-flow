public class LeaveInformation{
    public int LeaveRequestId { get; set; }
    public int EmployeeId { get; set; }
    public int LeaveTypeId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public LeaveStatus Status { get; set; }
    public DateTime DateRequested { get; set; }
    public DateTime? DateActioned { get; set; }

    public string? ApprovedBy { get; set; }

    public Employee Employee { get; set; }
    public LeaveType LeaveType { get; set; }

}