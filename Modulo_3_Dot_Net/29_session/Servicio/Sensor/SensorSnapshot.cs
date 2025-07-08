namespace Servicio.Sensor;

// Represents a snapshot of sensor data at a specific point in time.
public record SensorSnapshot(
    DateTime Timestamp,
    float? CpuTemp,
    float? GpuTemp,
    float? CpuLoad,
    float? GpuLoad,
    int MemoryUseMb,
    int FanRpm
);