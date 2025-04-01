using Microsoft.EntityFrameworkCore;

public class LeaveDbContext:DbContext{
  public LeaveDbContext(DbContextOptions<LeaveDbContext> options):base(options)
  {
    
  }
  
}