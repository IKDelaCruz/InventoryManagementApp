using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    class ErrorLogger
    {
        public static void LogException(Exception ex)
        {
            var log = (DateTime.Now.ToString());
            log += Environment.NewLine;
            log += (ex.Message);
            log += Environment.NewLine;
            log += (ex.StackTrace);

            Write(log);
        }
        private static void Write(string log)
        {
            
            var path = Path.Combine(Directory.GetCurrentDirectory(), "error.txt");
            if (!File.Exists(path))
            {
               var fs =  File.Create(path); 
                fs.Close();
                fs.Dispose();
            }



            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(log);
            }
        }
    }
}
