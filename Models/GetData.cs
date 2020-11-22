using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("GetData")]
    public class GetData
    {
        public GetData() : base()
        {
            Id = Guid.NewGuid();
        }

        // *****
        [Key]
        public Guid Id { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Code))]
        public string Code { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Name))]
        public string Name { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Date))]
        public string Date { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.YearSeason))]
        public string YearSeason { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ContractNumber))]
        public string ContractNumber { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ContractCount))]
        public string ContractCount { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.NoContractCount))]
        public string NoContractCount { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.InvoiceNumber))]
        public string InvoiceNumber { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Count))]
        public string Count { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.PerSale))]
        public string PerSale { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.NetSales))]
        public string NetSales { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.Discount))]
        public string Discount { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.SalesTax))]
        public string SalesTax { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ReturnedCount))]
        public string ReturnedCount { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.RefundAmount))]
        public string RefundAmount { get; set; }
        // *****

        // *****
        [MaxLength(150)]
        [Display(ResourceType = typeof(Resources.GetData),
            Name = nameof(Resources.GetData.ReceivedMoney))]
        public string ReceivedMoney { get; set; }
        // *****
    }
}