using Microsoft.EntityFrameworkCore;

namespace TodoApp2.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
          
        
        public DbSet<Todo> Todos { get; set; }

    
    
    
    }
}
