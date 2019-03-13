using System;
using System.Xml.Linq;

namespace XML_Description
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("The Hyndai Elentra 2019 model and it latest features"),
                new XElement("Car", 
                    new XAttribute("Name", "Hyundai Elentra"),

  

                    new XElement("Car", new XAttribute("Type", 1),
                        new XElement("Model", "Hyundai Elentra 1.6 Executive MT"),
                        new XElement("FuelConsumption", "6.5 Litres/100Km"),
                        new XElement("Co2Emissions", "155g/km"),
                        new XElement("Displacement", "1591cc"),
                        new XElement("Power", "93Kw"),
                        new XElement("Torque", "155Nm"),
                        new XElement("Price", "R323900")),

                   new XElement("Car", new XAttribute("Type", 2),
                        new XElement("Model", "Hyundai Elentra 1.6 Executive AT"),
                        new XElement("FuelConsumption", "6.9 Litres/100Km"),
                        new XElement("Co2Emissions", "161g/km"),
                        new XElement("Displacement", "1591cc"),
                        new XElement("Power", "93Kw"),
                        new XElement("Torque", "155Nm"),
                        new XElement("Price", "R343900")),

                   new XElement("Car", new XAttribute("Type", 3),
                        new XElement("Model", "Hyundai Elentra 1.6 TGDI Elite DCT Sport"),
                        new XElement("FuelConsumption", "7.9 Litres/100Km"),
                        new XElement("Co2Emissions", "164g/km"),
                        new XElement("Displacement", "1591cc"),
                        new XElement("Power", "150Kw"),
                        new XElement("Torque", "265Nm"),
                        new XElement("Price", "R424900")),

                   new XElement("Car", new XAttribute("Type", 4),
                        new XElement("Model", "Hyundai Elentra 2.0 Executive MT"),
                        new XElement("FuelConsumption", "8.3 Litres/100Km"),
                        new XElement("Co2Emissions", "174g/km"),
                        new XElement("Displacement", "1591cc"),
                        new XElement("Power", "115Kw"),
                        new XElement("Torque", "195Nm"),
                        new XElement("Price", "R378900"))));


            xDoc.Save("C:/Users/User/source/repos/XML_Description/XML_Description/XMLDoc.xml");
        }
    }
}
