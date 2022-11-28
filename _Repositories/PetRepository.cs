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

    public void Add(PetModel pet)
    {
      using (MySqlDb db = new MySqlDb(_connectionString))
      {
        db.Execute("INSERT INTO pet(pet_id, pet_name, pet_type, pet_colour) VALUES (@id, @name, @type, @colour)", new MySqlParam[]
        {
          new MySqlParam(){Name = "@id", Value = pet.Id},
          new MySqlParam(){Name = "@name", Value = pet.Name},
          new MySqlParam(){Name = "@type", Value = pet.Type},
          new MySqlParam(){Name = "@colour", Value = pet.Colour},
        });
      }
    }

    public void Delete(string id)
    {
      using (MySqlDb db = new MySqlDb(_connectionString))
      {
        db.Execute("DELETE FROM pet WHERE pet_id = @id", new MySqlParam[]
        {
          new MySqlParam(){Name = "@id", Value = id},
        });
      }
    }

    public void Edit(PetModel pet)
    {
      using (MySqlDb db = new MySqlDb(_connectionString))
      {
        db.Execute("UPDATE pet SET pet_name = @name, pet_type = @type, pet_colour = @colour WHERE pet_id = @id", new MySqlParam[]
        {
          new MySqlParam(){Name = "@id", Value = pet.Id},
          new MySqlParam(){Name = "@name", Value = pet.Name},
          new MySqlParam(){Name = "@type", Value = pet.Type},
          new MySqlParam(){Name = "@colour", Value = pet.Colour},
        });
      }
    }

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
                                      new MySqlParam() {Name = "?name", Value = $"%{value}%"},
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
