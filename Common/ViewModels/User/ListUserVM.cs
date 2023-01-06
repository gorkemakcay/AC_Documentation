using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels.User
{
    internal class ListUserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? UserType { get; set; }
        public string Title { get; set; }
        public int Gender { get; set; }
        public string? Department { get; set; }
        public string? UserCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? EducationStatus { get; set; }
        public string DefaultListType { get; set; }
        public string PhotoPath { get; set; }
        public string SignaturePath { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
