using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace dts_blazor_app.Api.Entities
{
    public class Role : IdentityRole<Guid>
    {
        [MaxLength(250)]
        [Required]
        public string Description { get; set; }
    }
}
