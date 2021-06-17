using System;
using System.IO;
using System.Xml.Serialization;

namespace Serializer
{
    public class Man {
        public string _name { get; set; }
        public int _age { get; set; }

        public Man(string name, int age) {
            _name = name;
            _age = age;
        }
        public Man() { }
    }
    public class ManXML
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public int _age { get; set; }

        public ManXML(string name, int age)
        {
            Name = name;
            _age = age;
        }

        public ManXML() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Man boy = new Man("Daniel", 15);
            XmlSerializer serializer = new XmlSerializer(typeof(Man));
            FileStream stream = new FileStream("File.xml", FileMode.Create, FileAccess.Write);

            serializer.Serialize(stream, boy);
            stream.Close();

            ManXML man = new ManXML("Kalmuratov Daniel", 27);
            XmlSerializer serializerXML = new XmlSerializer(typeof(ManXML));
            FileStream streamXML = new FileStream("FileXML.xml", FileMode.Create, FileAccess.Write);
            serializerXML.Serialize(streamXML, man);
            streamXML.Close();
            Console.WriteLine("Serialized!");
            Console.ReadKey();
        }
    }
}
