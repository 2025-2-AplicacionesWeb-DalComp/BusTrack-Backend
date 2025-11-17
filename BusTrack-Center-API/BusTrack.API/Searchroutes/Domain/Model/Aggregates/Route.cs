using BusTrack_center_API.Searchroutes.Domain.Model.Commands;

namespace BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;

public class Route
{
    public Route(string name, string stop, string estimatedTime, int frequency)
    {
        Name = name;
        Stop = stop;
        EstimatedTime = estimatedTime;
        Frequency = frequency;
    }

    public Route(CreateRouteCommand command)
        : this(command.Name, command.Stop, command.EstimatedTime, command.Frequency)
    { }

    public int Id { get;  }
    public string Name { get; private set; }
    public string Stop { get; private set; }
    public string EstimatedTime { get; private set; }
    public int Frequency { get; private set; }
}