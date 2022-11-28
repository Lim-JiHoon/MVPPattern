using MVPPattern.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPattern
{
  public partial class PetView : Form, IPetView
  {
    // Fields
    private string _message;
    private bool _isSuccessful;
    private bool _isEdit;

    // Constructor
    public PetView()
    {
      InitializeComponent();

      AssociateAndRaiseViewEvents();
      tab.TabPages.Remove(tabPagePetDetail);
    }

    private void AssociateAndRaiseViewEvents()
    {
      btnSearch.Click += (s,e) => SearchEvent?.Invoke(s,e);
      txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(s, e); };

    }

    // Properties
    public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }
    public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }
    public string PetType { get => txtPetId.Text; set => txtPetId.Text = value; }
    public string PetColour { get => txtPetColour.Text; set => txtPetColour.Text = value; }
    public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
    public bool isEdit { get => _isEdit; set => _isEdit = value; }
    public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
    public string Message { get => _message; set => _message = value; }

    // Events
    public event EventHandler SearchEvent;
    public event EventHandler AddNewEvent;
    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    // Methods
    public void SetPetListBindingSource(BindingSource petList)
    {
      dataGridView.DataSource = petList;
    }
  }
}
