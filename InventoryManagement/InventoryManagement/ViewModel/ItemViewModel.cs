using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    //public enum PrimaryItemType
    //{
    //    Asset = 1,
    //    Licenses,
    //    Accesories,
    //    Consumable
    //}
    //public enum SecondaryItemType
    //{
    //    CPUSet = 1,
    //    AllInOnePC,
    //    Laptop,
    //    Server,
    //    Switch,
    //    Router,
    //    Firewall,
    //    Monitor,
    //    HDD,
    //    Memory,
    //    UPS,
    //    Printer
    //}

    public enum ItemStatus
    {

        Available = 0,
        Borrowed,
        Reserved,
        Broken,
        Disposed,
       // Unknown
    }
    public enum ItemLoginType
    {
        Unknown = 0,
        Local,
        ActiveDirectory,
    }
    public enum PrinterType
    {
        Unknown = 0,
        Local,
        Network,
    }
    //public enum ItemOperatingSystem
    //{
    //    Unknown,
    //    WindowsNT,
    //    WindowsXP,
    //    Windows7,
    //    Windows8,
    //    Windows10,
    //    OSX,
    //    Windows2003,
    //    Windows2008,
    //    Windows2012,
    //    Ubuntu,
    //    Centos,
    //    EXSI,
    //    IOS,
    //    Android
    //}
    public enum ItemProcessors
    {
        Unknown,
        PentiumI,
        PentiumII,
        PentiumIII,
        DualCore,
        Core2Duo,
        I3,
        I5,
        I7,
        Xeon,
        AMD
    }
    public enum ItemMemory
    {
        Unknown,
        DDRII256,
        DDRII512,
        DDRII1024,
        DDRIII2GB,
        DDRIII4GB,
        DDRIII6GB,
        DDRIII8GB,
        DDRIII12GB
    }
    public enum ItemHDDCapacity
    {
        Unknown,
        IDE256,
        IDE500,
        SATA500,
        SATA1TB,
        SATA2TB,
        SATA4TB,

    }

    public class OSViewModel : ParentChildViewModel
    {
    }
    public class BrandViewModel : ParentChildViewModel
    {
    }


    public class ItemViewModel
    {
        public int Id { get; set; }
        public bool IsSummary { get; set; }
        public int SummaryCount { get; set; }
        public string AssetTag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public int SubTypeId { get; set; }
        public string SubType { get; set; }
        public string Brand { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalvageValue { get; set; }
        public decimal Currentvalue { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int LifeSpan { get; set; }
        public ItemStatus Status { get; set; }
        public int CurrentOwner { get; set; }
        public int CurrentDepartment { get; set; }
        public int CurrentCompany { get; set; }
        public string CurrentDepartmentName { get; set; }
        public string CurrentCompanyName { get; set; }
        public string CurrentOwnerName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public int LastUpdatedUserId { get; set; }
        public int OS { get; set; }
        public ItemProcessors Processor { get; set; }
        public ItemMemory Memory { get; set; }
        public ItemHDDCapacity HDD1 { get; set; }
        public ItemHDDCapacity HDD2 { get; set; }

        public Image Picture { get; set; }

        public ItemLoginType LoginType { get; set; }
    }
}
