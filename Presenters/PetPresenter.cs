using MVPPattern.Models;
using MVPPattern.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPattern.Presenters
{
  public class PetPresenter
  {
    //Fields
    private IPetView _view;
    private IPetRepository _repostory;
    private BindingSource _petsBindingSource;
    private IEnumerable<PetModel> _petList;

    #region Constructor
    public PetPresenter(IPetView view, IPetRepository repostory)
    {
      _view = view;
      _repostory = repostory;

      _view.SearchEvent += SearchPet;
      _view.AddNewEvent += AddNewPet;
      _view.EditEvent += LoadSelectedPetToEdit;
      _view.DeleteEvent += DeleteSelectedPet;
      _view.SaveEvent += SavePet;
      _view.CancelEvent += CancelAction;
      
      _petsBindingSource = new BindingSource();
      _view.SetPetListBindingSource(_petsBindingSource);
      LoadAllPetList();
      _view.Show();
    }
    #endregion

    #region Methods
    #endregion
    private void LoadAllPetList()
    {
      _petList = _repostory.GetAll();
      _petsBindingSource.DataSource = _petList;
    }

    private void SearchPet(object sender, EventArgs e)
    {
      bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchValue);
      if (!emptyValue)
      {
        _petList = _repostory.GetByValue(_view.SearchValue);
      }
      else
      {
        _petList = _repostory.GetAll();
      }
      _petsBindingSource.DataSource = _petList;
    }

    private void CancelAction(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void SavePet(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void DeleteSelectedPet(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void LoadSelectedPetToEdit(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    private void AddNewPet(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

  

    // Constructor


  }
}
