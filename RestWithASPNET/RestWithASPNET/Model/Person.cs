using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("lastName")]
        public string LastName { get; set; }
        [Column("adress")]
        public string Adress { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}