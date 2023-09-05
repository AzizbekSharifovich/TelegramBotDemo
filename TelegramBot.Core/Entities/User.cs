using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Core.Entities;
public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public long ChatId { get; set; }
    public string? FullName { get; set; }
    public string? UserName { get; set; }
    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedDate { get; set; }
    public virtual bool IsDeleted { get; set; } = false;
}

