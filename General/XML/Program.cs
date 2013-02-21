using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace XMLBasics
{

    public class DummyTargetClass
    {
        public string Name
        {
            get;
            set;
        }
        public bool IsFriend
        {
            get;
            set;
        }
        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
    }
    

    class Program
    {
        /// <summary>
        /// Reads an XML file.
        /// </summary>
        /// <param name="path"></param>
        static void ReadXMLFile(string path)
        {
            // Create a file stream so that we can read the data.
            using (XmlTextReader reader = new XmlTextReader(path))
            {                
                // The load the document DOM
                XmlDocument document = new XmlDocument();
                document.Load(reader);

                // Grab the first node
                XmlNode mainNode = document.FirstChild;
                mainNode         = mainNode.NextSibling;
                 
                //XmlElement element = document.GetElementById("Targets");

                // Then get the list of nodes containing the data we want. 
                XmlNodeList nodes = mainNode.ChildNodes; //.ChildNodes;
                
                foreach (XmlNode node in nodes)
                {
                    double yPos     = Convert.ToDouble(node.Attributes["yPos"].Value);
                    double xPos     = Convert.ToDouble(node.Attributes["xPos"].Value);
                    double zPos     = Convert.ToDouble(node.Attributes["zPos"].Value);
                    bool isFriend   = Convert.ToBoolean(node.Attributes["isFriend"].Value);
                     
                    XmlAttribute attribute = node.Attributes[0];
                    Console.WriteLine("x: {0} y: {1} z: {2}  Is Friend: {3}", xPos, yPos, zPos, isFriend);                                                                                
                }
            }
        }

        static void Main(string[] args)
        {
            // Here is one way to solve this: http://support.microsoft.com/kb/307548
            // But I will show you another.
            ReadXMLFile(args[0]);
        }
    }
}
