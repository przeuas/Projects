using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)//tworzenie
        {
            XDocument documentXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Books",
                    new XElement("Book",
                        new XAttribute("Id", 0),
                        new XElement("Title", "Inżynieria oprogramowania"),
                        new XElement("Author", "Ian Sommerville"),
                        new XElement("Pages", 685),
                        new XElement("Publisher", "WNT"))));
            //Printing creating document
            Console.WriteLine(documentXML);
            Console.WriteLine("###########po utworzeniu  elementu\n");
            documentXML.Save(@"s:\plik.xml"); //zapisywanie
           

            XDocument loadFromDisk = XDocument.Load(@"s:\plik.xml");   //odczytywanie
            Console.WriteLine(loadFromDisk);
            Console.Read();

            

            XElement root = loadFromDisk.Root;
            root.Add(new XElement("Book",
                new XAttribute("Id", 1),
                new XElement("Title", "Podstawy programowania współbierznego i rozproszonego"),
                new XElement("Author", "Mordechai Ben-Ari"),
                new XElement("Pages", 332),
                new XElement("Publisher", "WNT")));
            //documentXML.Save(@"s:\plik.xml");

            Console.WriteLine("###########po dodaniu elementu");
            Console.WriteLine(loadFromDisk);

             //loadFromDisk = XDocument.Load(@"s:\plik.xml");
            var query = from a in loadFromDisk.Root.Elements("Book")
                        where int.Parse(a.Attribute("Id").Value) == 1
                        select a;
            Console.WriteLine("#############szukamy po id");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            documentXML.Save(@"s:\plik.xml");


            Console.ReadLine();
            // loadFromDisk = XDocument.Load(@"s:\plik.xml");
            var query1 = from a in loadFromDisk.Root.Elements("Book")
                        where int.Parse(a.Attribute("Id").Value) == 1
                        select a;

            foreach (var item in query1)
            {
                item.ReplaceAll(new XAttribute("Id", 10),
                    new XElement("Title", "Robinson Crusoe"),
                    new XElement("Author", "Daniel Defoe"),
                    new XElement("Pages", 242),
                    new XElement("Publisher", "Wordsworth classics"));
            }
            Console.WriteLine("#############zmiana elementu");
            Console.WriteLine(loadFromDisk);
            Console.ReadLine();
            documentXML.Save(@"s:\plik.xml");
        }
    }
}