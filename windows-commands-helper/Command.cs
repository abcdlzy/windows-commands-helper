using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace windows_commands_helper
{
    public class Command
    {
        [Key]
        public string ClassName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
