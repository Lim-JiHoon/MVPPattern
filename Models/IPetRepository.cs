﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPattern.Models
{
  public interface IPetRepository
  {
    IEnumerable<PetModel> GetAll();
    IEnumerable<PetModel> GetByValue(string searchValue);
  }
}
