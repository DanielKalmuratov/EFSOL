using System;
using System.IO;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("0702343121");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Daniel Kalmuratov");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();



            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    if (xmlReader.Name.Equals("Contact"))
                    {
                        Console.WriteLine("<{0}>", xmlReader.GetAttribute("TelephoneNumber"));
                    }
                }
            }

            xmlReader.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
