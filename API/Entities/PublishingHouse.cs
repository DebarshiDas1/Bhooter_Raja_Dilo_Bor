using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BhooterRajaDiloBor.Entities
{
    /// <summary> 
    /// Represents a publishinghouse entity with essential details
    /// </summary>
    public class PublishingHouse
    {
        /// <summary>
        /// Primary key for the PublishingHouse 
        /// </summary>
        [Key]
        public int? Id { get; set; }
        /// <summary>
        /// CompanyName of the PublishingHouse 
        /// </summary>
        public string? CompanyName { get; set; }
        /// <summary>
        /// Location of the PublishingHouse 
        /// </summary>
        public string? Location { get; set; }
        /// <summary>
        /// EmployeeStrength of the PublishingHouse 
        /// </summary>
        public int? EmployeeStrength { get; set; }
        /// <summary>
        /// BooksSold of the PublishingHouse 
        /// </summary>
        public int? BooksSold { get; set; }
    }
}