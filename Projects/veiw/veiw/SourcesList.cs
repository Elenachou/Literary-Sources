using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Windows.Forms;
using Model;

namespace view
{
    public class SourcesList : List<ILiterarySource>, IXmlSerializable
    {
        public SourcesList() : base() { }

        public System.Xml.Schema.XmlSchema GetSchema() { return null; }

        public void ReadXml(XmlReader reader)
        {
            try
            {
                reader.ReadStartElement("SourcesList");
                while (reader.IsStartElement("ILiterarySource"))
                {
                    Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                    XmlSerializer serial = new XmlSerializer(type);

                    reader.ReadStartElement("ILiterarySource");
                    Add((ILiterarySource)serial.Deserialize(reader));
                    reader.ReadEndElement();
                }
                reader.ReadEndElement();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Файл поврежден");
            }
            catch (XmlException)
            {
                MessageBox.Show("Файл пуст");
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (ILiterarySource source in this)
            {
                writer.WriteStartElement("ILiterarySource");
                writer.WriteAttributeString("AssemblyQualifiedName", source.GetType().AssemblyQualifiedName);
                XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
                xmlSerializer.Serialize(writer, source);
                writer.WriteEndElement();
            }
        }
    }
}
