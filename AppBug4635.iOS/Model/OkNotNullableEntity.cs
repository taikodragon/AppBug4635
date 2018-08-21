using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppBug4635.Model
{
    public class OkNotNullableEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }
        public bool NotNullable1 { get; set; }
        public bool NotNullable2 { get; set; }
        public bool NotNullable3 { get; set; }
        public bool NotNullable4 { get; set; }
        public bool NotNullable5 { get; set; }
        public bool NotNullable6 { get; set; }
        public bool NotNullable7 { get; set; }
        public bool NotNullable8 { get; set; }
        public bool NotNullable9 { get; set; }
        public bool NotNullable10 { get; set; }
        public bool NotNullable11 { get; set; }
        public bool NotNullable12 { get; set; }
        public bool NotNullable13 { get; set; }

        public OkNotNullableEntity()
        {
            Key = 0;
            NotNullable1 = false;
            NotNullable2 = false;
            NotNullable3 = false;
            NotNullable4 = false;
            NotNullable5 = false;
            NotNullable6 = false;
            NotNullable7 = false;
            NotNullable8 = false;
            NotNullable9 = false;
            NotNullable10 = false;
            NotNullable11 = false;
            NotNullable12 = false;
            NotNullable13 = false;
        }
    }
}
