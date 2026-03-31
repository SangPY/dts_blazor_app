using dts_blazor_app.Api.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace dts_blazor_app.Api.Entities
{
    public class TodoTask
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        public Guid? AssigneeId { get; set; }

        [ForeignKey("AssigneeId")]
        public Guid? Assignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

    }
}
