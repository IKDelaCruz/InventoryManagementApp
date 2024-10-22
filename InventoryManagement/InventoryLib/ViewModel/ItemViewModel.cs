﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public enum ItemStatus
    {

        Available = 0,
        Borrowed,
        Reserved,
        Broken,
        Disposed,
        Assigned
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

    public enum ItemProcessors
    {
        Unknown,
        PentiumI,
        PentiumII,
        PentiumIII,
        Pentium4,
        Celeron,
        DualCore,
        QuadCore,
        Core2Duo,
        Core2Quad,
        CoreI3,
        CoreI5,
        CoreI7,
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
        DDRIII3GB,
        DDRIII4GB,
        DDRIII6GB,
        DDRIII8GB,
        DDRIII12GB
    }
    public enum ItemHDDCapacity
    {
        Unknown,
        IDE80,
        IDE120,
        IDE160,
        IDE256,
        IDE320,
        IDE500,
        SATA500,
        SATA600,
        SATA1TB,
        SATA2TB,
        SATA4TB,

    }
    public enum AttachmentType
    {
        Image = 1,
        Document

    }
    public class OSViewModel : ParentChildViewModel
    {
    }
    public class BrandViewModel : ParentChildViewModel
    {
    }
    public class AttachmentViewModel : ParentChildViewModel
    {
    }
    public class ItemViewModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public bool IsSummary { get; set; }
        public int SummaryCount { get; set; }
        public string AssetTag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
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
        public PrinterType PrinterType { get; set; }
        public string NetworkIP { get; set; }
        public string NetworkSubnet { get; set; }
        public string NetworkGateway { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }

        public string SalesInvoiceNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public ItemViewModel()
        {
            PurchaseDate = DateTime.Now;
            LastUpdatedDate = DateTime.Now;
            BrandId = 13;
            Description = "";
        }
    }
}


