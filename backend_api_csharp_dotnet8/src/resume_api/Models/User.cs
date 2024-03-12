using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Models
{
  [Table("users")]
  [Index(nameof(UserId))]
  public class User
  {
    [Column("userid")]
    [Key]
    public int UserId { get; set; }

    [Column("firstname")]
    public required string FirstName { get; set; }

    [Column("middlename")]
    public string? MiddleName { get; set; }

    [Column("lastname")]
    public required string LastName { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("zip")]
    public int? Zip { get; set; }
  }
}