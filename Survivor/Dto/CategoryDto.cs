using Survivor.Data.Entities;

namespace Survivor.Dto
{
    public class CategoryDto : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}