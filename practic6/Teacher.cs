using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic5
{
    class Teacher : Person, ITeacher
    {
        public string Subject { get; set; }

        public void Teach()
        {
            MessageBox.Show($"{FullName} викладає предмет: {Subject}");
        }
    }
}
