public class LeaveType{
  public int Id  {get;set;};
  public string Name {get;set;}=default.Empty;
  public int LeaveDays {get;set;}=default.Empty;
  public int LeaveBalance {get;set;}=default.Empty;
  public date StartDate {get;set;}=default.Empty;
  public date EndDate {get;set;}=default.Empty;


}