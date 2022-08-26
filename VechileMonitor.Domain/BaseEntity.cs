using System.ComponentModel.DataAnnotations;

namespace VechileMonitor.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
