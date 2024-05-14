using PCMonitoringConsoleApp.Utils;

CPUMonitoring cpuMonitoring = new CPUMonitoring();
Monitoring monitoring = new Monitoring();
monitoring.listAllHardware();

while (true)
{
    cpuMonitoring.updateState();
    Console.WriteLine("Cpu temp: {0}°C",cpuMonitoring.Temp);
    Console.WriteLine("Cpu load: {0}%",cpuMonitoring.Load);
    Console.WriteLine("Cpu avgFrequency: {0} GHz",cpuMonitoring.AvgFrequency);
    Console.WriteLine("Cpu power consumption: {0}W", cpuMonitoring.Consumption);
    Thread.Sleep(1000);
}