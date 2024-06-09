using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DungeonMasterWebApp_2022.Models;
using DungeonMasterDomain_2022;
using DungeonMasterDTO_2022;

namespace DungeonMasterWebApp_2022.Controllers
{
    public class ItemController : Controller
    {
        private DungeonItemInteractor _interactor;

        public ItemController()
        {
            _interactor = new DungeonItemInteractor();
        }

        // GET: ItemController
        public ActionResult Index()
        {
            List<ItemViewModel> items = new List<ItemViewModel>();

            // Using LINQ 
            // _interactor.GetAllItems().ForEach(item => items.Add(ItemViewModel.ViewModelMapper(item)));

            List<Item> dbItems = _interactor.GetAllItems();
            foreach (Item item in dbItems)
            {
                ItemViewModel viewItem = ItemViewModel.ViewModelMapper(item);
                items.Add(viewItem);
            }

            return View(items);
        }

        // GET: ItemController/Details/5
        public ActionResult Details(int id)
        {
            if (_interactor.GetItemIfExists(id, out Item dbItem))
            {
                ItemViewModel viewItem = ItemViewModel.ViewModelMapper(dbItem);
                return View(viewItem);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: ItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Item itemToAdd = ItemViewModel.ItemDtoMapperForCreate(collection);
                _interactor.AddNewItem(itemToAdd);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: ItemController/Edit/5
        public ActionResult Edit(int id)
        {
            if (_interactor.GetItemIfExists(id, out Item dbItem))
            {
                ItemViewModel viewItem = ItemViewModel.ViewModelMapper(dbItem);
                return View(viewItem);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Item itemToUpdate = ItemViewModel.ItemDtoMapperForUpdate(collection);
                _interactor.UpdateItem(itemToUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Delete/5
        public ActionResult Delete(int id)
        {
            if (_interactor.GetItemIfExists(id, out Item dbItem))
            {
                ItemViewModel viewItem = ItemViewModel.ViewModelMapper(dbItem);
                return View(viewItem);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _interactor.DeleteItem(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
