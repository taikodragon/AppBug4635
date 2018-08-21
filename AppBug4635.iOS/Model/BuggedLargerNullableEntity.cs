using System;
using System.ComponentModel.DataAnnotations;

namespace AppBug4635.Model
{
    public class BuggedLargerNullableEntity
    {
        [Key]
        public Guid Key { get; set; }
        public int NotNullable1 { get; set; }
        public int? Nullable1 { get; set; }
        public Guid? Nullable2 { get; set; }
        public Guid? Nullable3 { get; set; }
        public Guid? Nullable4 { get; set; }
        public DateTime NotNullable2 { get; set; }
        public DateTime NotNullable3 { get; set; }
        public string Nullable5 { get; set; }
        public DateTime NotNullable4 { get; set; }
        public DateTime? Nullable6 { get; set; }
        public DateTime? Nullable7 { get; set; }

        public BuggedLargerNullableEntity()
        {
            Key = Guid.NewGuid();
        }
    }
}
