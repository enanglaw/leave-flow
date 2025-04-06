using Microsoft.EntityFrameworkCore;

public class LeaveDbContext:DbContext{
  public LeaveDbContext(DbContextOptions<LeaveDbContext> options):base(options)
  {
    
  }

  DbSet<Unit> Units {get;set;}
  DbSet<Department> Departments {get;set;}
  DbSet<LeaveAllocation> LeaveAllocations {get;set;}
  DbSet<LeaveInformation> LeaveInformations {get;set;}
  DbSet<LeaveType> LeaveTypes {get;set;}
  DbSet<Staff> Staffs {get;set;}
  DbSet<Unit> Units {get;set;}
}