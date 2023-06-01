using System.ComponentModel.DataAnnotations;

namespace Gameshop.Domain.Models.Common;

public class BaseEntity<T>
{
    [Key]
    public T Id { get; set; }
}