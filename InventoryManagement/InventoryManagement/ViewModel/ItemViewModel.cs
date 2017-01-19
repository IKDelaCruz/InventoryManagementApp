using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public enum PrimaryItemType
    {
        Asset = 1,
        Licenses,
        Accesories,
        Consumable
    }
    public enum SecondaryItemType
    {
        CPUSet = 1,
        AllInOnePC,
        Laptop,
        Server,
        Switch,
        Router,
        Firewall,
        Monitor,
        HDD,
        Memory,
        UPS,
        Printer
    }
    
    public enum ItemStatus
    {
        Available,
        Borrowed,
        Broken,
        Disposed,
        Unknown
    }
    public class BrandViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string AssetTag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PrimaryItemType Type { get; set; }
        public SecondaryItemType SubType { get; set; }
        public string Brand { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Currentvalue { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int LifeSpan { get; set; }
        public ItemStatus Status { get; set; }
        public int CurrentOwner { get; set; }
        public string CurrentOwnerName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUser { get; set; }
        public int LastUpdatedUserId { get; set; }
    }
}
