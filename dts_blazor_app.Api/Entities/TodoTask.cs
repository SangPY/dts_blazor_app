using dts_blazor_app.Api.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace dts_blazor_app.Api.Entities
{
    public class TodoTask
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid? Assignee { get; set; }

        public DateTime CreatedDate { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

    }
}
