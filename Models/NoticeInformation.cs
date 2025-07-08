namespace viet_trip_backend.Models
{
    public class NoticeInformation
    {
        public Guid Id { get; set; }
        public string PriceIncluded {  get; set; }
        public string PriceNotIncluded {  get; set; }
        public string CancelInfor {  get; set; }
        public string CancelCondition {  get; set; }
        public string ChildrenNotice {  get; set; }
        public string CancelConditionOnHoliday {  get; set; }
        public string Payment {  get; set; }
        public string SpecialIssue {  get; set; }
        public string RegisterCondition {  get; set; }
        public string Contact {  get; set; }
    }
}
