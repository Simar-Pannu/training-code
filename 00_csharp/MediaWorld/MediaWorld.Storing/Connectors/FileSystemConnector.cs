using System.Collections.Generic;
using System.Xml.Serialization;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Storing.Connectors
{
  public class FileSystemConnector {
    private const string _path = @"storage.xml";
    public void ReadXml(string path = _path){
      var xml = new XmlSerializer(typeof(List<AMedia>));
      var reader = new StreamReader(path);
      var data = xml.Deserialize(reader) as List<AMedia>;

      
    }

    public void WriteXml(){

    }



  }
}
