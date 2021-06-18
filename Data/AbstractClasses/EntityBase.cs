using System.ComponentModel.DataAnnotations.Schema;
using Data.Interfaces;

namespace Data.AbstractClasses
{
    public class EntityBase : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}