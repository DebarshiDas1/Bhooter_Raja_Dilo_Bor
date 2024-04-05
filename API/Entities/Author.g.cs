using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BhooterRajaDiloBor.Entities
{
    /// <summary> 
    /// Represents a author entity with essential details
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Initializes a new instance of the Author class.
        /// </summary>
        public Author()
        {
            BooksSold = -1;
        }

        /// <summary>
        /// Primary key for the Author 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Author 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// TenantId of the Author 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// CreatedOn of the Author 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Author 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the Author 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Author 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
        /// <summary>
        /// Location of the Author 
        /// </summary>
        public string? Location { get; set; }
        /// <summary>
        /// BooksSold of the Author 
        /// </summary>
        public int? BooksSold { get; set; }
    }
}