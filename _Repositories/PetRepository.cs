using MVPPattern._Data.Models;
using MVPPattern.Data;
using MVPPattern.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPattern._Repositories
{
  public class PetRepository : BaseRepository, IPetRepository
  {
    public PetRepository(string connectionString) : base(connectionString) { }

    public IEnumerable<PetModel> GetAll()
    {
      List<PetModel> pets = new List<PetModel>();

      using (MySqlDb db = new MySqlDb(_connectionString))
      using (var dr = db.GetReader("SELECT * FROM pet ORDER BY pet_id DESC"))
        while (dr.Read())
        {
          PetModel pet = new PetModel(dr);
          pets.Add(pet);
        }

      return pets;
    }

    public IEnumerable<PetModel> GetByValue(string value)
    {
      List<PetModel> pets = new List<PetModel>();

      using (MySqlDb db = new MySqlDb(_connectionString))
      using (var dr = db.GetReader("SELECT * FROM pet " +
                                    "WHERE pet_id = ?id OR pet_name LIKE ?name " +
                                    "ORDER BY pet_id DESC",
                                    new MySqlParam[]
                                    {
                                      new MySqlParam() {Name = "?id", Value = value},
                                      new MySqlParam() {Name = "?name", Value = $"{value}%"},
                                    }))
        while (dr.Read())
        {
          PetModel pet = new PetModel(dr);
          pets.Add(pet);
        }

      return pets;
    }
  }
}
