using System.ComponentModel.DataAnnotations;

namespace Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess
{
    public class DataAcessEntityFrameworkSettings
    {
        [Required]
        public string DefaultConnection { get; set; }
    }
}