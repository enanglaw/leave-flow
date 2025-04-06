public class Staff{
   public int Id { get; set; }
    public string StaffId { get; set; }
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
     public int UnitId { get; set; }
    public Unit Unit { get; set; }
    get FullName(){
      return FirstName+' '+LastName;
    }
    public ICollection<LeaveInformation> LeaveInformations { get; set; }
}