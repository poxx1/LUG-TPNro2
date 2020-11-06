using BE_Propiedades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace BLL_Negocio
{
    public class XML
    {
        public List<BE_Programs> Read()
        {
            //en load va la direccion del archivo, si pongo solo el nombre, es xq e guarda en el servidor
            //luego los elementos y atributos como estan estructurado en el XML

            string path = @"C:\Users\Poxi\Documents\UAI\2020\LUG\TP 2\LUG-TPNro2\Documentos\ServersList.xml";

            var query =
                from Programs in XElement.Load(path).Elements("Programs")
                select new BE_Programs
                {
                    name = Convert.ToString(Programs.Attribute("Program").Value).Trim(),
                    version = Convert.ToString(Programs.Element("Version").Value).Trim(),
                    platform = Convert.ToString(Programs.Element("Platform").Value).Trim()
                };

            List<BE_Programs> List_Programs = query.ToList<BE_Programs>();
            return List_Programs;
        }

        public void Write(string prog, string ver, string platf)
        {
            string path = @"C:\Users\Poxi\Documents\UAI\2020\LUG\TP 2\LUG-TPNro2\Documentos\ServersList.xml";
            XDocument xmlDoc = XDocument.Load(path);
            // en el Xdocument, utilizo, y agrego como esta estructurado el XML
            xmlDoc.Element("Programs").Add(new XElement("Programs",
                                        new XAttribute("Program", prog),
                                        new XElement("Version", ver),
                                        new XElement("Platform", platf)
                                       ));

            //luego el metodo save guarda lo ingresado en el XML
            xmlDoc.Save(path);
        }

        public void Create(string prog, string ver, string platf)
        {
            XmlTextWriter archivoxml = new XmlTextWriter(@"C:\Users\Poxi\Documents\UAI\2020\LUG\TP 2\LUG-TPNro2\Documentos\ServersList.xml", System.Text.Encoding.UTF8);
            archivoxml.Formatting = Formatting.Indented;
            //identation es para que se escriba nueva lineas
            archivoxml.Indentation = 2;
            archivoxml.WriteStartDocument(true);
            archivoxml.WriteStartElement("Programs");
            archivoxml.WriteAttributeString("Program", prog);
            archivoxml.WriteElementString("Version", ver);
            archivoxml.WriteElementString("Platform", platf);
            archivoxml.WriteEndElement();
            archivoxml.WriteEndDocument();
            archivoxml.Close();
        }
    }
}
