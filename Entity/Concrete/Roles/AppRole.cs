using Entity.Abstract;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace Entity.Concrete.Roles
{
    public class AppRole : IdentityRole<int>, IEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
