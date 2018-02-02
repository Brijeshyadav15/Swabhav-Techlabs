using System;
using System.IO;
namespace ResumeBuilderApp
{
    class ResumeBuilder
    {
        private String _name;
        private String _mobile;
        private String _age;
        private String _percentage;
        private String _address;

        public ResumeBuilder(String name, String mobile, String age, String percentage, String address)
        {
            _name = name;
            _mobile = mobile;
            _age = age;
            _percentage = percentage;
            _address = address;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public String Mobile
        {
            get
            {
                return _mobile;
            }
        }

        public String Age
        {
            get
            {
                return _age;
            }
        }

        public String Percentage
        {
            get
            {
                return _percentage;
            }
        }

        public String Address
        {
            get
            {
                return _address;
            }
        }

        public void BuildResume()
        {
            StreamReader streamreader = new StreamReader("Resumes/resume.html");
            String htmldata = "";
            using (streamreader)
            {
                while (streamreader.ReadLine() != null)
                {
                    htmldata += streamreader.ReadLine();
                }
                htmldata = htmldata.Replace("null", "");
                htmldata = htmldata.Replace("##name##", Name);
                htmldata = htmldata.Replace("##age##", Age);
                htmldata = htmldata.Replace("##address##", Address);
                htmldata = htmldata.Replace("##percentage##", Percentage);
                htmldata = htmldata.Replace("##mobilenumber##", Mobile);
            }
            String fileName = "Resumes/" + Name + "Resume.html";
            File.WriteAllText(fileName, htmldata);
            Console.WriteLine(fileName);
        }

    }
}
