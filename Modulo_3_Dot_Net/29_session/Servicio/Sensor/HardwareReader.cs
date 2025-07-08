using LibreHardwareMonitor.Hardware;


namespace Servicio.Sensor;

/// <summary> Wrapper de LibreHardwareMonitor para leer datos de hardware. </summary>
public sealed class HardwareReader : IVisitor
{
    /// <summary> Constructor que inicializa el lector de hardware. </summary>
    private readonly Computer _computer;

    //Las útimas lecturas de los sensores.
    private float? _cpuTemp, _gpuTemp, _cpuLoad, _gpuLoad;
    public int _memUsed, _fan;

    public HardwareReader()
    {
        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsControllerEnabled = true,
        };
        _computer.Open();
    }

    public SensorSnapshot Capture()
    {
        _computer.Accept(this);

        return new SensorSnapshot(
            Timestamp: DateTime.Now,
            CpuTemp: _cpuTemp,
            GpuTemp: _gpuTemp,
            CpuLoad: _cpuLoad,
            GpuLoad: _gpuLoad,
            MemoryUseMb: _memUsed,
            FanRpm: _fan
        );
    }

    public void VisitSensor(ISensor sensor)
    {
        switch (sensor.SensorType)
        {   
            // Se manejan los diferentes tipos de sensores.
            case SensorType.Temperature:
                // Asignar las temperaturas de CPU y GPU basadas en el nombre del sensor.
                if (sensor.Name.Contains("CPU", StringComparison.OrdinalIgnoreCase))
                {
                    _cpuTemp = sensor.Value;
                }
                else if (sensor.Name.Contains("GPU", StringComparison.OrdinalIgnoreCase))
                {
                    _gpuTemp = sensor.Value;
                }
                break;

            // Se manejan los diferentes tipos de sensores.
            case SensorType.Load:
                if (sensor.Name.Contains("CPU Total"))
                {
                    _cpuLoad = sensor.Value;
                }
                else if (sensor.Name.Contains("GPU Total"))
                {
                    _gpuLoad = sensor.Value;
                }
                break;

            // Se manejan los diferentes tipos de sensores.
            case SensorType.Fan:
                _fan = (int?)sensor.Value ?? _fan;
                break;

            case SensorType.Data:
                if (sensor.Name.Equals("Memory Used", StringComparison.OrdinalIgnoreCase))
                {
                    _memUsed = (int)((sensor.Value ?? 0)) / 1024; // Convertir a MB
                }
                break;
                
        }
    }

    public void VisitComputer(IComputer computer)
    {
        foreach (var hw in computer.Hardware)
        {
            // Visitar cada hardware para capturar sus sensores.
            hw.Update(); // Asegurarse de que los datos estén actualizados.
            hw.Accept(this);    
        }
    }

    public void VisitHardware(IHardware hardware)
    {
        foreach (var sensor in hardware.Sensors)
            VisitSensor(sensor);
    }

    public void VisitParameter(IParameter parameter)
    {
        throw new NotImplementedException();
    }

}   