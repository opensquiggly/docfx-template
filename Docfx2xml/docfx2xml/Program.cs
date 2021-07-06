using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Docfx2xml.Converter;
using Docfx2xml.DI;
using Docfx2xml.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace Docfx2xml
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var serviceProvider = new ServiceCollection().RegisterAppServices();
      var logger = serviceProvider.GetService<ILogger>();
      var dataConverter = serviceProvider.GetService<IDataConverter>();

      var stopWatch = new Stopwatch();
      try
      {
        stopWatch.Start();
        await dataConverter.ConvertAsync();
      }
      catch (Exception ex)
      {
        logger.LogError(ex);
      }
      stopWatch.Stop();
      logger.LogInformation($"Spend time: {stopWatch.ElapsedMilliseconds} ms");
      
      Console.WriteLine("Press any key to exit...");
      Console.ReadLine();
    }
  }
}
