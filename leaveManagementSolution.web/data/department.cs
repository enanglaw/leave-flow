public class Department{

 public int Id  {get;set;};
  public string Name {get;set;}=default.Empty;
  public ICollection<Unit> Units { get; set; }
}