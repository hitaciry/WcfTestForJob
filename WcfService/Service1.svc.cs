using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        private WCFDbEntities db = new WCFDbEntities();

        public void AddClient(string inn, string name, int type, string contracts, DateTime dateContract)
        {
            db.clients.Add(new client(inn, name, type, contracts, dateContract));
            db.SaveChanges();
        }

        public List<client> GetClients()
        {
                var result = db.clients.ToList();
            return result;
        }

        public void RemoveClient(int id)
        {
            var c = db.clients.Find(id);
            db.clients.Remove(c);
            db.SaveChanges();
        }

        public void UpdateClient(int id, string inn, string name, int type, string contracts)
        {
            var c = db.clients.Find(id);
            c.INN = inn;
            c.name = name;
            c.type = type;
            c.contacts = contracts;
            db.clients.
            db.SaveChanges();
        }
    }
}