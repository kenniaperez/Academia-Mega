using System.Globalization;
using System.Text;

namespace Servicio.Sensor;

public class CsWriter
{
    private const string Header =
        "Timestamp;CpuTemp;GpuTemp;CpuLoad;GpuLoad;MemoryMB;FanRpm";

    // path donde se guardarán los logs
    private readonly string _path = "logs";
    // Directorio donde se guardarán los logs
    private readonly object _sync = new();

    // StringBuilder para construir el contenido del archivo
    public CsWriter()
    {
        Directory.CreateDirectory(_path);
    }

    // StringBuilder para construir el contenido del archivo
    public void Write(SensorSnapshot s)
    {
        var file = Path.Combine(_path, $"{DateTime.Today:yyyyMMdd}.csv");

        // Asegurarse de que el directorio existe
        var sb = new StringBuilder()
            .Append(s.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")).Append(';')
            .Append(s.CpuTemp).Append(';')
            .Append(s.GpuTemp).Append(';')
            .Append(s.CpuLoad).Append(';')
            .Append(s.GpuLoad).Append(';')
            .Append(s.MemoryUseMb).Append(';')
            .Append(s.FanRpm).Append(';');

        lock (_sync)
        {
            // Se invierte la validación de si el archivo existe o no para crearlo
            var writeHeader = !File.Exists(file);
            using var sw = new StreamWriter(file, append: true, Encoding.UTF8);
            if (writeHeader)
                sw.WriteLine(Header);
            sw.WriteLine(sb.ToString());
        }
    }

    // public void WriteLine(string format, params object[] args)
    // {
    //     _sb.AppendLine(string.Format(CultureInfo.InvariantCulture, format, args));
    // }

    // public override string ToString()
    // {
    //     return _sb.ToString();
    // }
}