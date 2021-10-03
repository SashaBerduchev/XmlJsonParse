using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlJsonParse
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.WriteLine("Lets start");
            OpenXml();
            
        }

        public static void OpenXml()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    
                    string jsonstring = "";
                    openFileDialog.ShowDialog();
                    var file = openFileDialog.FileName.ToString();
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(file);
                    jsonstring = JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.Indented);
                    Console.WriteLine(jsonstring);
                    Console.Read();
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.ToString());
                    Console.Read();
                }
                
            }
        }
    }
}
