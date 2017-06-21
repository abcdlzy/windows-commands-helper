using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace windows_commands_helper
{
    public partial class wch : Form
    {
        public wch()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            using (var context = new CMDContext())
            {
                var cmd = new Command();
                cmd.ClassName = "1";
                cmd.Description = "d";
                cmd.Name = "1";
                context.Commands.Add(cmd);
                context.SaveChanges();
                Console.WriteLine(context.Commands.Count());
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
