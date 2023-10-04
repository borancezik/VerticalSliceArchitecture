using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Offices.Models
{
    public class OfficeEntity : IEntity
    {
        [Column("officeCode")]
        [Key]
        public int Id { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("addressLine1")]
        public string? AdressLine1 { get; set; }

        [Column("addressLine2")]
        public string? AdressLine2 { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("postalCode")]
        public string? PostalCode { get; set; }

        [Column("territory")]
        public string? Territory { get; set; }
    }
}
