using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPattern.Models
{
  public class PetModel
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Colour { get; set; }

    public PetModel() { }

    public PetModel(DbDataReader dr)
    {
      Id = (string)dr["pet_id"];
      Name = (string)dr["pet_name"];
      Type = (string)dr["pet_type"];
      Colour = (string)dr["pet_colour"];
    }
  }
}
