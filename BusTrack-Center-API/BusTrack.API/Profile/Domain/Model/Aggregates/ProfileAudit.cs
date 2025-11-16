using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace BusTrack.API.Profiles.Domain.Model.Aggregates; // si no funciona usen al inicio using BusTrack_center_API

public partial class Profile : IEntityWithCreatedUpdatedDate
{
   [Column("CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }
   [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set; }
}
