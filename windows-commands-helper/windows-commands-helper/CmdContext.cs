using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace windows_commands_helper
{
    class CMDContext:DbContext
    {
        public CMDContext() : base("SqliteCommands")
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
