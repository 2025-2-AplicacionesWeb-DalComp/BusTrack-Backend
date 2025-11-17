namespace BusTrack_center_API.Searchroutes.Domain.Model.Commands;

public record CreateRouteCommand(string Name, string Stop, string EstimatedTime, int Frequency);
