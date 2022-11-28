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
      IPetView view = new PetView();
      IPetRepository repository = new PetRepository(sqlConnectionString);
     new PetPresenter(view, repository);

      Application.Run((Form)view);
    }
  }
}
