namespace viet_trip_backend.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Url {  get; set; }
    }
}
