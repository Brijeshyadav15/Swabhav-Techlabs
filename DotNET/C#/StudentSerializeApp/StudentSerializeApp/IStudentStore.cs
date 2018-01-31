using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSerializeApp
{
    interface IStudentStore
    {
        void Init();

        void Add(Student student);

        List<Student> Get();

        Student Search(String name);

        String Delete(long id);

        void Export();
    }
}
