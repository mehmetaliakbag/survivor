namespace Survivor.Data.Entities
{
    public class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
