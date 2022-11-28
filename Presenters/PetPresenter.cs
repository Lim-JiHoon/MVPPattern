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
      _view.StartApplication();
    }
    #endregion

    #region Methods
    #endregion
    private void LoadAllPetList()
    {
      _petList = _repostory.GetAll();
      _petsBindingSource.DataSource = _petList;
    }

    private void Clear()
    {
      _view.PetId = "";
      _view.PetName = "";
      _view.PetType = "";
      _view.PetColour = "";
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

    private void AddNewPet(object sender, EventArgs e)
    {
      _view.IsEdit = false; 
    }

    private void LoadSelectedPetToEdit(object sender, EventArgs e)
    {
      var pet = (PetModel)_petsBindingSource.Current;
      _view.PetId = pet.Id;
      _view.PetName = pet.Name;
      _view.PetType = pet.Type;
      _view.PetColour = pet.Colour;
      _view.IsEdit = true;  
    }

    private void SavePet(object sender, EventArgs e)
    {
      var pet = new PetModel();
      pet.Id = _view.PetId;
      pet.Name = _view.PetName;
      pet.Type = _view.PetType;
      pet.Colour = _view.PetColour;

      try
      {
        new Common.ModelDataValidation().Validate(pet);
        if (_view.IsEdit)
        {
          _repostory.Edit(pet);
          _view.Message = "펫 정보가 수정되었습니다.";
        }
        else
        {
          _repostory.Add(pet);
          _view.Message = "펫 정보가 저장되었습니다.";
        }
        _view.IsSuccessful = true;
        Clear();
      }catch(Exception ex)
      {
        _view.IsSuccessful=false;
        _view.Message =ex.Message;
      }
    }  

    private void CancelAction(object sender, EventArgs e)
    {
      Clear();
    }     

    private void DeleteSelectedPet(object sender, EventArgs e)
    {
      try
      {
        var pet = (PetModel)_petsBindingSource.Current;
        _repostory.Delete(pet.Id);
        _view.IsSuccessful = true;
        _view.Message = "펫이 삭제되었습니다.";
        LoadAllPetList();
      }catch(Exception ex)
      {
        _view.IsSuccessful=!false;
        _view.Message=ex.Message;
      }
    }
  }
}
