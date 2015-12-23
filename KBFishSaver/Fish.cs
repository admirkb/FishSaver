using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KBFishSaver
{
    public class Fish
    {
        public void XmlOut(string filePath)
        {
            try
            {
                // Create a new XmlSerializer instance with the type of the test class
                XmlSerializer SerializerObj = new XmlSerializer(this.GetType());

                // Create a new file stream to write the serialized object to a file
                TextWriter WriteFileStream = new StreamWriter(filePath);
                SerializerObj.Serialize(WriteFileStream, this);

                WriteFileStream.Close();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
