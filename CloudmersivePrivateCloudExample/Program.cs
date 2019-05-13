using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;
using System;
using System.Diagnostics;

namespace CloudmersivePrivateCloudExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR-KEY-HERE");
            
            // Specify your private cloud endpoint
            Configuration.Default.BasePath = "http://cloudmersiveprivatecloud.westus.cloudapp.azure.com";


            var apiInstance = new ScanApi();
            var inputFile = new System.IO.FileStream("C:\\temp\\document2.pdf", System.IO.FileMode.Open); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Scan a file for viruses
                VirusScanResult result = apiInstance.ScanFile(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.ScanFile: " + e.Message);
            }
        }
    }
}
