using Microsoft.EntityFrameworkCore;
using TI_BOOT.Models;

namespace TI_BOOT.Context
{
    public class ChatContext: DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<RespostaChat> RespostaChat { get; set; }


    }
}
