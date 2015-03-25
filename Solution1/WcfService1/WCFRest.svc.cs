using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFRest" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFRest.svc o WCFRest.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFRest : IWCFRest
    {
        private List<User> UsersFromDataBase = new List<User>() 
        {
            new User(){id=1,Name="Juan",Email="Juan@gmail.com"},
            new User(){id=2,Name="Pedro",Email="Pedro@gmail.com"},
            new User (){id=3,Name="Magaly",Email="Magaly@gmail.com"}

        };
        public List<User> ShowJson(string name) 
        {
            return GetUsersByName(name);
        }
        public List<User> ShowXml(string name) 
        {
            return GetUsersByName(name);
        }

        private List<User> GetUsersByName(string name) 
        {
            return this.UsersFromDataBase.Where(w => w.Name == name).Select(s => s).ToList<User>();
        }
    }
}
