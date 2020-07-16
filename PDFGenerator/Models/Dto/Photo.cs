using System;

namespace PDFGenerator.Models.Dto
{
    public class Photo
    {
        public Int32 ID { get; set; }
        public Int32 ClientID { get; set; }
        public Int32 CompanyID { get; set; }
        public Int32 TaskID { get; set; }
        public Int32 MyImageID { get; set; }
        public Boolean? IsBefore { get; set; }
        public Boolean? IsCurrent { get; set; }
        public Boolean? IsAfter { get; set; }
        public Int32 PictureOrder { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
