using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic5
{
    class DepartmentChair : Teacher, IPerson
    {
        public event EventHandler DepartmentMeeting; // Подія для звітів

        public void OrganizeMeeting()
        {
            MessageBox.Show($"{FullName} організовує зібрання кафедри");
            DepartmentMeeting?.Invoke(this, EventArgs.Empty);
        }
    }
}
