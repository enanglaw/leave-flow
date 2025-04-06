public class Unit {
   public int Id  {get;set;};
  public string Name {get;set;}=default.Empty;
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public ICollection<Staff> Employees { get; set; }
}
