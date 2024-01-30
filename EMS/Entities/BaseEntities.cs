namespace EMS.Entities
{
    public class BaseEntities
    {
        public int? CreatedBy {  get; set; }
        public int? UpdatedBy { get; set;}
        public int? DeletedBy { get; set; }
        public DateTime? CreatedDate {  get; set; }
        public DateTime? UpdatedDate { get; set;}
        public DateTime? DeletedDate { get; set; }

    }
}
