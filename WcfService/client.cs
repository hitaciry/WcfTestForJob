//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class client
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string INN { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int type { get; set; }
        [DataMember]
        public System.DateTime dateContract { get; set; }
        [DataMember]
        public string contacts { get; set; }
        public client()
        {

        }
        public client(string inn, string name, int type, string contracts, DateTime dateContract)
        {
            this.INN = inn;this.name = name;this.type = type;this.contacts = contacts;this.dateContract = dateContract;
        }

        public virtual type_client type_client { get; set; }
    }
}
