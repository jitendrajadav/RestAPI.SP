using SQLite.Net.Attributes;

namespace RestWPF.Model
{
    public class Address
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Pin { get; set; }
        public string Phone { get; set; }
        public string Addreses { get; set; }

    }
}
