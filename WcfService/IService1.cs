using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddClient(string inn, string name, int type, string contracts, DateTime dateContract);

        [OperationContract]
        void UpdateClient(int id, string inn, string name, int type, string contracts);

        [OperationContract]
        void RemoveClient(int id);

        [OperationContract]
        List<client> GetClients();
    }   
}