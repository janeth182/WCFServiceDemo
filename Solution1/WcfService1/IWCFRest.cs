using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWCFRest" en el código y en el archivo de configuración a la vez.

    [DataContract]
    public class User
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
    [ServiceContract]
    //public interface IWCFRest
    //{
    //    [OperationContract]
    //    [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Json,UriTemplate="show/json/{name}")]
    //    List<User> ShowJson(string name);

    //    [OperationContract]
    //    [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Xml,UriTemplate="show/xml/{name}")]
    //    List<User> ShowXml(string name);
        
    }
}
