using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoList.Controllers
{
  public class TagsController : Controller
  {
    private readonly ToDoListContext _db;

    public TagsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Tags.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      _db.Tags.Add(tag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisTag = _db.Tags
          .Include(tag => tag.Items)
          .ThenInclude(join => join.Item)
          .FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    public ActionResult Edit(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);
      ViewBag.ItemsId = new SelectList(_db.Items, "ItemId", "Description");
      return View(thisTag);
    }

    [HttpPost]
    public ActionResult Edit(Tag tag, int ItemId)
    {
      if (ItemId != 0)
      {
        _db.CategoryItemTags.Add(new CategoryItemTag() { ItemId = ItemId, TagId = tag.TagId });
      }
      _db.Entry(tag).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddItem(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);
      ViewBag.ItemId = new SelectList(_db.Items, "ItemId", "Description");
      return View(thisTag);
    }

    [HttpPost]
    public ActionResult AddItem(Tag tag, int ItemId)
    {
      if (ItemId != 0)
      {
        _db.CategoryItemTags.Add(new CategoryItemTag() { ItemId = ItemId, TagId = tag.TagId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);
      return View(thisTag);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);
      _db.Tags.Remove(thisTag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteItem(int joinId)
    {
      var joinEntry = _db.CategoryItemTags.FirstOrDefault(entry => entry.CategoryItemTagId == joinId);
      _db.CategoryItemTags.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}