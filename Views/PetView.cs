using Microsoft.Extensions.Logging;
using MVPPattern.Models;
using MVPPattern.Presenters;
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
using Microsoft.Extensions.DependencyInjection;

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
      btnSearch.Click += (s, e) => SearchEvent?.Invoke(s, e);
      txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(s, e); };
      btnAddNew.Click += (s, e) =>
      {
        AddNewEvent?.Invoke(s, e);
        tab.TabPages.Remove(tabPagePetList);
        tab.TabPages.Add(tabPagePetDetail);
        tabPagePetDetail.Text = "Add new pet";
      };
      btnEdit.Click += (s, e) =>
      {
        EditEvent?.Invoke(s, e);
        tab.TabPages.Remove(tabPagePetList);
        tab.TabPages.Add(tabPagePetDetail);
        tabPagePetDetail.Text = "Edit pet";
      };
      btnSave.Click += (s, e) =>
      {
        SaveEvent?.Invoke(s, e);
        if (IsSuccessful)
        {
          tab.TabPages.Remove(tabPagePetDetail);
          tab.TabPages.Add(tabPagePetList);
        }
        MessageBox.Show(Message);
      };
      btnCancel.Click += (s, e) =>
      {
        CancelEvent?.Invoke(s, e);
        tab.TabPages.Remove(tabPagePetDetail);
        tab.TabPages.Add(tabPagePetList);
      };
      btnDelete.Click += (s, e) =>
      {
        var result = MessageBox.Show("삭제하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          DeleteEvent?.Invoke(s, e);
          MessageBox.Show(Message);
        }
      };
    }

    // Properties
    public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }
    public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }
    public string PetType { get => txtPetType.Text; set => txtPetType.Text = value; }
    public string PetColour { get => txtPetColour.Text; set => txtPetColour.Text = value; }
    public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
    public bool IsEdit { get => _isEdit; set => _isEdit = value; }
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

    private void button1_Click(object sender, EventArgs e)
    {
      var t = Program.ServiceProvider.GetRequiredService<Form1>();
      t.Show();
    }

    public void StartApplication()
    {
      Application.Run(this);
    }
  }
}
