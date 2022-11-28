using MVPPattern._Repositories;
using MVPPattern.Models;
using MVPPattern.Presenters;
using MVPPattern.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVPPattern
{
  static class Program
  {
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string sqlConnectionString = Properties.Settings.Default.SqlConnectionString;
      //IPetView view = new PetView();
      //IPetRepository repository = new PetRepository(sqlConnectionString);
      //new PetPresenter(view, repository);

      //Application.Run((Form)view);

      var host = CreateHostBuilder().Build();
      ServiceProvider = host.Services;
      ServiceProvider.GetRequiredService<PetPresenter>();

      //Application.Run(ServiceProvider.GetRequiredService<PetView>());
    }
    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
      return Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
          services.AddTransient<IPetRepository, PetRepository>(s=> new PetRepository(Properties.Settings.Default.SqlConnectionString));
          services.AddTransient<IPetView, PetView>();
          services.AddTransient<PetPresenter>(s => new PetPresenter(s.GetService<IPetView>(), s.GetService<IPetRepository>()));
          services.AddTransient<PetView>();
          services.AddTransient<Form1>();
        });
    }
  }
}
