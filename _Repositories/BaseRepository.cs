using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPattern._Repositories
{
  public abstract class BaseRepository
  {
    protected string _connectionString;

    public BaseRepository(string connectionString)
    {
      _connectionString = connectionString;
    }
  }
}
