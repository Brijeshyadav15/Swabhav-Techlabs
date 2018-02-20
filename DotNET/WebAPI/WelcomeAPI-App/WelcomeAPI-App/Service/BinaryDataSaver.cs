using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WelcomeAPI_App.Controllers
{
    class BinaryDataSaver
    {
        public void SaveStudents(List<Student> studentList)
        {
            BinaryFormatter _formatter = new BinaryFormatter();
            FileStream _filestream = null;
            try
            {
                _filestream = new FileStream("E:/Swabhav_Techlabs/Cloud Repository/brijesh-techlabs-training/DotNET/Solid Principles/StudentAppSolution/StudentWinForm/bin/Debug/Data/Student.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            }
            catch
            {

            }
            using (_filestream)
            {
                _formatter.Serialize(_filestream, studentList);
            }
        }
    }
}
