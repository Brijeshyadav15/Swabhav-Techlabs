using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StateServiceApp
{
    class StateService
    {
        Dictionary<String, String> states = new Dictionary<string, string>();

        public StateService()
        {
            init();
        }

        private void init()
        {
            String line;
            StreamReader streamReader = new StreamReader("States.csv");
            try
            {
                using (streamReader)
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        String[] state = line.Split(',');
                        states.Add(state[0], state[1]);
                    }
                }
            }
            catch
            {
                //Console.WriteLine("Exception occured");
            }
        }

        public Dictionary<String, String> Search(String code)
        {
            code = code.ToUpper();

            Dictionary<String, String> temp = new Dictionary<String, String>();

            foreach (KeyValuePair<string, string> entry in states)
            {

                if (code.Length == 1 && entry.Key.StartsWith(code.Substring(0, 1)))
                {
                    temp.Add(entry.Key, entry.Value);
                }
                else if (code.Length == 2 && states.ContainsKey(code))
                {
                    temp.Add(entry.Key, entry.Value);
                }
            }
            return temp;
        }
    }
}
