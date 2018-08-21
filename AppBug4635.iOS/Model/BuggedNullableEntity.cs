using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppBug4635.Model
{
    public class BuggedNullableEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }
        public long? Nullable1 { get; set; }
        public long? Nullable2 { get; set; }
        public long? Nullable3 { get; set; }
        public long? Nullable4 { get; set; }

        public BuggedNullableEntity()
        {
            Key = 0;
        }
    }
}
