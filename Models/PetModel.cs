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
    public string PetId { get; set; }
    public string PetName { get; set; }
    public string PetType { get; set; }
    public string PetColour { get; set; }

    public PetModel() { }

    public PetModel(DbDataReader dr)
    {
      PetId = (string)dr["pet_id"];
      PetName = (string)dr["pet_name"];
      PetType = (string)dr["pet_type"];
      PetColour = (string)dr["pet_colour"];
    }
  }
}
