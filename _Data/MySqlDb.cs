using MVPPattern._Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;

namespace MVPPattern.Data
{
  public class MySqlDb : IDisposable
  {
    private MySqlConnection _conn;
    private string _connectionString;
    
    private bool Connection()
    {
      _conn = new MySqlConnection(_connectionString);
      try
      {
        _conn.Open();
        return true;
      }catch( Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.ToString());
        Dispose();
        return false;
      }
    }

   
    public MySqlDb(string connectionString)
    {
      _connectionString = connectionString;
      Connection();
    }

    public bool IsConnected()
    {
      return _conn?.State == ConnectionState.Open;
    }

    public DbDataReader GetReader(string query)
    {
      return GetReader(query, CommandBehavior.Default);
    }

    public DbDataReader GetReader(string query, CommandBehavior commandBehavior)
    {
      using (MySqlCommand cmd = new MySqlCommand(query, _conn))
      {
        return cmd.ExecuteReader(commandBehavior);
      }
    }

    public DbDataReader GetReader(string query, MySqlParam[] parameters)
    {
      return GetReader(query, parameters, CommandBehavior.Default);
    }

    public DbDataReader GetReader(string query, MySqlParam[] parameters, CommandBehavior commandBehavior)
    {
      using (MySqlCommand cmd = new MySqlCommand(query, _conn))
      {
        foreach (MySqlParam parameter in parameters)
        {          
          cmd.Parameters.AddWithValue(parameter.Name, parameter.Value);
        }
        return cmd.ExecuteReader(commandBehavior);
      }
    }

    public long Execute(string query)
    {
      using (MySqlCommand cmd = new MySqlCommand(query, _conn))
      {
        cmd.ExecuteNonQuery();
        return cmd.LastInsertedId;
      }
    }

    public long Execute(string query, MySqlParam[] parameters)
    {
      using (MySqlCommand cmd = new MySqlCommand(query, _conn))
      {
        foreach (MySqlParam parameter in parameters)
        {
          cmd.Parameters.AddWithValue(parameter.Name, parameter.Value);
        }

        cmd.ExecuteNonQuery();
        return cmd.LastInsertedId;
      }
    }

    public void Dispose()
    {
      _conn?.Close();
      _conn?.Dispose();
      _conn = null;
    }
  }
}
