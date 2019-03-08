using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using NewXmlWork.Data;
using Newtonsoft.Json;
using NewXmlWork.Logic;
using System.Diagnostics;

namespace NewXmlWork
{
    class Program
    {

        static string pathForRead = ConfigurationSettings.AppSettings["pathForRead"];
        static string pathForMove = ConfigurationSettings.AppSettings["pathForMove"];
        static void Main(string[] args)
        {

            try
            {
                Stopwatch watch = new Stopwatch();
                TestLogicPerferomance betLogic = new TestLogicPerferomance(pathForRead, pathForMove);
                watch.Start();
                betLogic.ReadBetRadarDataFromXml();
                watch.Stop();
                Console.WriteLine("Reading files takes: " + watch.ElapsedMilliseconds);
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
