using BusTrack_center_API.Searchroutes.Domain.Model.Commands;

namespace BusTrack_center_API.Searchroutes.Domain.Model.Aggregates;

public class Ruta
{
    public Ruta(string name, string stop, string estimatedTime, int frequency)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required", nameof(name));
        if (string.IsNullOrWhiteSpace(stop)) throw new ArgumentException("Stop is required", nameof(stop));
        if (string.IsNullOrWhiteSpace(estimatedTime)) throw new ArgumentException("EstimatedTime is required", nameof(estimatedTime));
        if (frequency <= 0) throw new ArgumentOutOfRangeException(nameof(frequency), "Frequency must be greater than zero");

        Name = name;
        Stop = stop;
        EstimatedTime = estimatedTime;
        Frequency = frequency;
    }

    public Ruta(CreateRutaCommand command)
        : this(command.Name, command.Stop, command.EstimatedTime, command.Frequency)
    { }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Stop { get; private set; }
    public string EstimatedTime { get; private set; }
    public int Frequency { get; private set; }
}