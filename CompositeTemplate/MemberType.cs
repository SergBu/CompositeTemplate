using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTemplate
{
    /// <summary>
    /// Тип Контрагента
    /// </summary>
    [Serializable]
    [DataContract]
    public enum MemberType
    {
        /// <summary>
        /// Гость
        /// </summary>
        [DataMember]
        Guest = -1,

        /// <summary>
        /// Неопределенный
        /// </summary>
        [DataMember]
        None = 0,

        /// <summary>
        /// Грузовладелец
        /// </summary>
        [DataMember]
        CargoOwner = 100,

        /// <summary>
        /// Менеджер грузовладельца
        /// </summary>
        [DataMember]
        CargoOwnerManager = 101,

        /// <summary>
        /// Перевозчик
        /// </summary>
        [DataMember]
        Carrier = 200,

        /// <summary>
        /// Водитель
        /// </summary>
        [DataMember]
        Driver = 300,

        /// <summary>
        /// Администратор
        /// </summary>
        [DataMember]
        Admin = 700,

        /// <summary>
        /// Менеджер
        /// </summary>
        [DataMember]
        Manager = 701,

        /// <summary>
        /// Супервайзер
        /// </summary>
        [DataMember]
        SuperAdmin = 777,

        /// <summary>
        /// Грузоотправитель
        /// </summary>
        [DataMember]
        Consignor = 800,

        /// <summary>
        /// Трейдер
        /// </summary>
        [DataMember]
        Trader = 801,

        /// <summary>
        /// Организация
        /// </summary>
        [DataMember]
        Organization = 802,

        /// <summary>
        /// Терминал
        /// </summary>
        [DataMember]
        Terminal = 900,

        /// <summary>
        /// Терминал, диспетчер
        /// </summary>
        [DataMember]
        TerminalDispatcher = 901,

        /// <summary>
        /// Внутренний процесс
        /// </summary>
        InternalWorker = 999,
    }
}
