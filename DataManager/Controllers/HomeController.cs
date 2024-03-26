using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataManager.Models;
using ProjectData_Service.Models;
using Syncfusion.EJ2.Base;
using Microsoft.AspNetCore.Cors;
using static ProjectData_Service.Models.ProjectData;

namespace DataManager.Controllers
{
    public class HomeController : Controller
    {
        [EnableCors("AllowAllOrigins")]
        public IActionResult Index()
        {
            return View();
        }

        public static List<GanttDataSource> DataList = null;
        public List<GanttDataSource> addedRecords { get; set; }

        public IActionResult UrlDatasource([FromBody]DataManagerRequest dm)
        {
            if (DataList == null)
            {
                ProjectData datasource = new ProjectData();
                DataList = datasource.GetUrlDataSource();
            }
            var count = DataList.Count();
            return dm.RequiresCounts ? Json(new { result = DataList, count = count }) : Json(DataList);
        }

        public class CRUDModel
        {
            public List<GanttDataSource> Added { get; set; }
            public List<GanttDataSource> Changed { get; set; }
            public List<GanttDataSource> Deleted { get; set; }
            public GanttDataSource Value { get; set; }
            public int key { get; set; }
            public string action { get; set; }
        }

        public IActionResult BatchUpdate([FromBody]CRUDModel batchmodel)
        {
            if (batchmodel.Changed != null) // when a record is edited
            {
                for (var i = 0; i < batchmodel.Changed.Count(); i++)
                {
                    var value = batchmodel.Changed[i];
                    GanttDataSource result = DataList.Where(or => or.taskId == value.taskId).FirstOrDefault();
                    result.taskId = value.taskId;
                    result.taskName = value.taskName = "sid";
                    result.startDate = value.startDate;
                    result.endDate = value.endDate;
                    result.duration = value.duration;
                    result.progress = value.progress;
                    result.predecessor = value.predecessor;
                    result.resources = value.resources;
                    result.parentID = value.parentID;
                    result.TaskColor = value.TaskColor = "red";

                }
            }
            if (batchmodel.Deleted != null) // when a record is deleted
            {
                for (var i = 0; i < batchmodel.Deleted.Count(); i++)
                {
                    DataList.Remove(DataList.Where(or => or.taskId == batchmodel.Deleted[i].taskId).FirstOrDefault());
                    RemoveChildRecords(batchmodel.Deleted[i].taskId);
                }
            }
            if (batchmodel.Added != null) // when a record is added
            {
                for (var i = 0; i < batchmodel.Added.Count(); i++)
                {
                    DataList.Insert(0,batchmodel.Added[i]);
                    batchmodel.Added[i].TaskColor = "yellow";
                }
            }
            return Json(new { addedRecords = batchmodel.Added, changedRecords = batchmodel.Changed, deletedRecords = batchmodel.Deleted });
        }      
        public void RemoveChildRecords(int key)
        {
            var childList = DataList.Where(x => x.parentID == key).ToList();
            foreach (var item in childList)
            {
                DataList.Remove(item);
                RemoveChildRecords(item.taskId);
            }
        }
    }
}