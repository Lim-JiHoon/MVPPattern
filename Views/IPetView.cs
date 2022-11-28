using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPattern.Views
{
  public interface IPetView
  {
    string PetId { get; set; }
    string PetName { get; set; }
    string PetType { get; set; }
    string PetColour { get; set; }

    string SearchValue { get; set; }
    bool isEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    // Events
    event EventHandler SearchEvent;
    event EventHandler AddNewEvent;
    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    // Methods
    void SetPetListBindingSource(BindingSource petList);
    void Show();
  }
}
