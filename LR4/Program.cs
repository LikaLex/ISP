using System;
using System.Management;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");// Второй аргумент означает устройство , 
            foreach (ManagementObject queryObj in searcher1.Get())                                            //которое может интерпретировать последовательность команд на компьютере ,
            {                                                                                                         //работающих на операционной системе Windows
                Console.WriteLine("                        Win32_Processor instance ");
                Console.WriteLine("Name: {0} ", queryObj["Name"]);
                Console.WriteLine("NumberOfCores: {0}", queryObj["NumberOfCores"]);
                Console.WriteLine("ProcessorId: {0}", queryObj["ProcessorId"]);
            }
            
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");//Второй аргумент представляет возможности и 
            foreach (ManagementObject queryObj in searcher2.Get())                                   //потенциал управления видео контроллера на компьютер с операционной системой Windows.                                                                              
            {
                Console.WriteLine("                        Win32_VideoController instance");
                Console.WriteLine("AdapterRAM: {0}", queryObj["AdapterRAM"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("Description: {0}", queryObj["Description"]);
                Console.WriteLine("VideoProcessor: {0}", queryObj["VideoProcessor"]);
            }
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");// Второй аргумент - зампрос фильтров WMI
            foreach (ManagementObject queryObj in searcher3.Get())                          //WMI — это одна из базовых технологий для централизованного управления
            {                                                                          // и слежения за работой различных частей компьютерной инфраструктуры под управлением платформы Windows.
                Console.WriteLine("                         Win32_OperatingSystem instance");
                Console.WriteLine("BuildNumber: {0}", queryObj["BuildNumber"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("FreePhysicalMemory: {0}", queryObj["FreePhysicalMemory"]);
                Console.WriteLine("FreeVirtualMemory: {0}", queryObj["FreeVirtualMemory"]);
                Console.WriteLine("Name: {0}", queryObj["Name"]);
                Console.WriteLine("OSType: {0}", queryObj["OSType"]);
                Console.WriteLine("RegisteredUser: {0}", queryObj["RegisteredUser"]);
                Console.WriteLine("SerialNumber: {0}", queryObj["SerialNumber"]);
                Console.WriteLine("ServicePackMajorVersion: {0}", queryObj["ServicePackMajorVersion"]);
                Console.WriteLine("ServicePackMinorVersion: {0}", queryObj["ServicePackMinorVersion"]);
                Console.WriteLine("Status: {0}", queryObj["Status"]);
                Console.WriteLine("SystemDevice: {0}", queryObj["SystemDevice"]);
                Console.WriteLine("SystemDirectory: {0}", queryObj["SystemDirectory"]);
                Console.WriteLine("SystemDrive: {0}", queryObj["SystemDrive"]);
                Console.WriteLine("Version: {0}", queryObj["Version"]);
                Console.WriteLine("WindowsDirectory: {0}", queryObj["WindowsDirectory"]);
                Console.ReadKey();
            }
        }
    }
    
}


//Неуправляемый код - это обычный машинный код, который получается при компиляции исходного кода 