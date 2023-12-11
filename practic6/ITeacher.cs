using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic5
{
    interface ITeacher
    {
        string Subject { get; set; }
        void Teach();
    }
}
