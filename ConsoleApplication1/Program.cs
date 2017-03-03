using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ISOLogPullLibrary.LogPull logPull = new ISOLogPullLibrary.LogPull("starttime=2017-01-12T01:00", "endtime=2017-01-12T01:01");
            JArray logs = logPull.GetLogs();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = currentDirectory + "log.test";
            using (StreamWriter wr = new StreamWriter(path))
            {
              foreach(var log in logs)
                {
                    wr.WriteLine(log);
                }
            }*/
            Debug.WriteLine("test");
            Dictionary<string, string> test = new Dictionary<string, string>();
            test = ISOLogPullLibrary.CommandLineParser.Parse(args);
            foreach(KeyValuePair<string,string> kvp in test)
            {
                Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
            }
        }
    }
}
