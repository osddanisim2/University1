using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic5
{
    class Person : IPerson
    {
        public string FullName { get; set; }

        public void DisplayInfo()
        {
            MessageBox.Show($"ПІБ: {FullName}");
        }
    }
}
