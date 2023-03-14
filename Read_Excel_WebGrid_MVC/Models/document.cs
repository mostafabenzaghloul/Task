using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Read_Excel_WebGrid_MVC.Models
{
    
        public class DocumentFromExcel
        {
            public string DocumentID { get; set; }
            public string DocumentDate  { get; set; }
        public string DocumentType { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string CustomerCountryCode { get; set; }
        public string CustomerGovernate { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerBuildingNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductUnit { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductDiscountAmount { get; set; }
        public string ProductTaxTypeCode { get; set; }
        public string ProductTaxSubTypeCode { get; set; }
        public decimal ProductTaxRatio { get; set; }
   
}
}