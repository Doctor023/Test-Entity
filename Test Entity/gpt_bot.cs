using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entity
{
    [Table("gpt_bots")]
    internal class Gpt_bot
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("promt")]
        public string? Promt { get; set; }

        [Column("last_message")]
        public string? Last_message { get; set; }
    }
}
