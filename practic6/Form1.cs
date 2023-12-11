using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic5
{
    public partial class Form1 : Form
    {
        private DepartmentChair departmentChair;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departmentChair = new DepartmentChair
            {
                FullName = textBoxTeacher.Text,
                Subject = textBoxSubject.Text
            };
            Action<Person> personDelegate = person => person.DisplayInfo();
            Action<ITeacher> teacherDelegate = teacher => teacher.Teach();
            Action<IStudent> studentDelegate = student => student.Study();

            // Додання методів до події
            departmentChair.DepartmentMeeting += (s, args) => MessageBox.Show("Зібрання кафедри розпочалося!");

            // Виклик методів через делегат
            personDelegate(departmentChair);
            teacherDelegate(departmentChair);
            studentDelegate(new Student { FullName = textBoxStudent.Text, StudentId = 123 });

            // Виклик методів через делегат і подію
            departmentChair.OrganizeMeeting();
        }
    }
}
