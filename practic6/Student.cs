using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic5
{
    class Student : Person, IStudent
    {
        public int StudentId { get; set; }

        public void Study()
        {
            MessageBox.Show($"{FullName} вивчає матеріал");
        }
    }
}
