using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestP.Models
{
   public class CarsDetail
   {
      [Key]
      public int Id { get; set; }
      
      [Column(TypeName ="nvarchar(100)")]
      public string? LicensePlateNumber { get; set; }
      
      [Column(TypeName ="nvarchar(100)")]
      public string? Marke { get; set; }
      
      [Column(TypeName ="nvarchar(100)")]
      public string? Model { get; set; }
      
      [Column(TypeName ="nvarchar(100)")]
      public string? OwnerName { get; set; }
      
      [Column(TypeName ="nvarchar(250)")]
      public string? OwnerContactInfo { get; set; }

   }

}
