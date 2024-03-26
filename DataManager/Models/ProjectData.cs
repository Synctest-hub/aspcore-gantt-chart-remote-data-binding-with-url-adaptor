using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectData_Service.Models
{
    public class ProjectData
    {
        public List<GanttDataSource> GetUrlDataSource()
        {


            List<GanttDataSource> dataCollection = new List<GanttDataSource>();
            dataCollection = new List<GanttDataSource>() {
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 10,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 11,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 12,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 13,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 14,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 15,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 16,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 17,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 18,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 19,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 20,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 21,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 22,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 23,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 24,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 25,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 26,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 27,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 28,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 29,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 30,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 31,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 32,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 32,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 33,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 34,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 35,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 38,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 39,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 40,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 41,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 42,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 43,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 44,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 45,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 46,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 47,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 48,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 49,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 50,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 51,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 52,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 53,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 54,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 55,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 56,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 57,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 58,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 59,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 60,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 61,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 62,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 63,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 64,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 65,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 66,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 67,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 68,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 69,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 70,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 71,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 72,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 73,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 74,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    //startDate = null,
                   // endDate = null,
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               },
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70, ActivityId=40 },
                   new ResourceModel { ResourceId = 6 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { ResourceId = 2, ActivityId=40 },
                            new ResourceModel{ ResourceId = 3 , ActivityId=40},
                            new ResourceModel{ ResourceId = 5 , ActivityId=40}
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                        new ResourceModel { ResourceId = 9, ResourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 4, ResourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 8 },
                         new ResourceModel{ ResourceId = 4 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12, ActivityId=40 },
                         new ResourceModel{ ResourceId = 5, ResourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { ResourceId = 12 }
                    }
               }

            };
            return dataCollection;

        }



        public List<GanttResources> GetResources()
        {
            List<GanttResources> GanttResourcesCollection = new List<GanttResources>();

            GanttResources Record1 = new GanttResources()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer"
            };
            GanttResources Record2 = new GanttResources()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller"
            };
            GanttResources Record3 = new GanttResources()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan"
            };
            GanttResources Record4 = new GanttResources()
            {
                ResourceId = 4,
                ResourceName = "Fuller King"
            };
            GanttResources Record5 = new GanttResources()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller"
            };
            GanttResources Record6 = new GanttResources()
            {
                ResourceId = 6,
                ResourceName = "Van Jack"
            };
            GanttResources Record7 = new GanttResources()
            {
                ResourceId = 7,
                ResourceName = "Fuller Buchanan"
            };
            GanttResources Record8 = new GanttResources()
            {
                ResourceId = 8,
                ResourceName = "Jack Davolio"
            };
            GanttResources Record9 = new GanttResources()
            {
                ResourceId = 9,
                ResourceName = "Tamer Vinet"
            };
            GanttResources Record10 = new GanttResources()
            {
                ResourceId = 10,
                ResourceName = "Vinet Fuller"
            };
            GanttResources Record11 = new GanttResources()
            {
                ResourceId = 11,
                ResourceName = "Bergs Anton"
            };
            GanttResources Record12 = new GanttResources()
            {
                ResourceId = 12,
                ResourceName = "Construction Supervisor"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            GanttResourcesCollection.Add(Record7);
            GanttResourcesCollection.Add(Record8);
            GanttResourcesCollection.Add(Record9);
            GanttResourcesCollection.Add(Record10);
            GanttResourcesCollection.Add(Record11);
            GanttResourcesCollection.Add(Record12);
            return GanttResourcesCollection;
        }

        public class GanttDataSource
        {
            public int taskId { get; set; }
            public string taskName { get; set; }
            public DateTime? startDate { get; set; }
            public DateTime? endDate { get; set; }
            public string duration { get; set; }
            public int progress { get; set; }
            public string predecessor { get; set; }
            public int? parentID { get; set; }
            public List<ResourceModel> resources { get; set; }
            public string customColumn { get; set; }
            public string TaskColor { get; set; }

        }

        public class GanttResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
            public Nullable<int> Unit { get; set; }

        }
        public class ResourceModel
        {
            public int ResourceId { get; set; }
            public Nullable<int> ResourceUnit { get; set; }
            public Nullable<int> ActivityId { get; set; }
        }

    }
}