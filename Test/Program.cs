// See https://aka.ms/new-console-template for more information
using DustAnalyzerSampling;

Console.WriteLine("Hello, World!");

IDustAnalyzerSampling dustAnalyzerSampling = new DustAnalyzerSampling.DustAnalyzerSampling(new Communication.Bus.PhysicalPort.SerialPort("COM3", 38400));
await dustAnalyzerSampling.OpenAsync();
var rs = await dustAnalyzerSampling.Read("01");

Console.ReadLine();