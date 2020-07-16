using System;

namespace PDFGenerator.Models.Dto
{
    public class Client
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Country { get; set; }
        public String EmailAddress { get; set; }
        public String OfficePhone { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
