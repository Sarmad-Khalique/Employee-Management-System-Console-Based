using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL
    {
        protected static void Save(object data)
        {
            StreamWriter sw = new StreamWriter(new FileStream("Employees.txt", FileMode.Append, FileAccess.Write));
            string jsonString = JsonSerializer.Serialize(data);
            sw.WriteLine(jsonString);
            sw.Close();
        }

        protected static List<string> Read(string filename)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read));
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                list.Add(line);
            }
            sr.Close();
            return list;
        }
    }
}
