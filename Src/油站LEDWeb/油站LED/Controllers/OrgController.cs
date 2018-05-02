﻿using GlareSysEfDbAndModels;
using LmxPublic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OilStationLED.Controllers
{
    public class OrgController : Controller
    {
        //
        // GET: /Org/

        public ActionResult Index()
        {
            if (Session["SuperUser"] == null && Session["OrgUser"] == null && Session["GroupUser"] == null && Session["ProjectUser"] == null && Session["DevUser"] == null)
            {
                return RedirectToAction("Index", "Login", null);
            }
            else
            {
                if (Session["SuperUser"] != null)
                {
                    SuperLoginedUserModel userInfo = (SuperLoginedUserModel)(Session["SuperUser"]);
                    ViewBag.Name = userInfo.UserInfo.Name;
                }
                if (Session["OrgUser"] != null)
                {
                    OrgLoginedUserModel userInfo = (OrgLoginedUserModel)(Session["OrgUser"]);
                    ViewBag.Name = userInfo.UserInfo.Name;
                }
                if (Session["GroupUser"] != null)
                {
                    GroupLoginedUserModel userInfo = (GroupLoginedUserModel)(Session["GroupUser"]);
                    ViewBag.Name = userInfo.UserInfo.Name;
                }
                if (Session["ProjectUser"] != null)
                {
                    ProjectLoginedUserModel userInfo = (ProjectLoginedUserModel)(Session["ProjectUser"]);
                    ViewBag.Name = userInfo.UserInfo.Name;
                }
                if (Session["DevUser"] != null)
                {
                    CommDevLoginedUserModel userInfo = (CommDevLoginedUserModel)(Session["DevUser"]);
                    ViewBag.Name = userInfo.UserInfo.Name;
                }
            }
            return View();
        }


        /// <summary>
        /// 展示Org
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult List(string Method, string Key)
        {
            object objResult = null;
            try
            {
                using (LedDbEntities db = new LedDbEntities())
                {
                    List<OrgInfo> list = new List<OrgInfo>();
                    if (Method == "FirstLoad")
                    {
                        list = db.OrgInfo.Where(p => p.IsDel != 1).ToList();
                    }
                    else if (Method == "SearchLoad")
                    {
                        list = db.OrgInfo.Where(p => p.Name.Contains(Key) && p.IsDel != 1).ToList();
                    }
                    int page = string.IsNullOrWhiteSpace(Request["page"]) ? 1 : Int32.Parse(Request["page"]);
                    int rows = string.IsNullOrWhiteSpace(Request["rows"]) ? 1 : Int32.Parse(Request["rows"]);
                    string order = string.IsNullOrWhiteSpace(Request["order"]) ? "DESC" : Request["order"].ToUpper();
                    string sort = string.IsNullOrWhiteSpace(Request["sort"]) ? "Id" : Request["sort"];
                    IQueryable<OrgInfo> query = CommonTools.DataSorting<OrgInfo>(list.AsQueryable(), sort, order).Skip((page - 1) * rows).Take(rows);
                    objResult = new { total = list.Count, rows = query };
                }
            }
            catch (Exception ex)
            {
                objResult = new ResultHelper()
                {
                    Desc = ex.Message,
                    Msg = ex.Message,
                    Obj = null,
                    Ret = -1,
                    Status = false
                };
                //throw;
            }
            return Json(objResult);
        }


        /// <summary>
        /// 添加Org
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(OrgInfo subject)
        {
            ResultHelper objResult = null;
            try
            {
                using (LedDbEntities db = new LedDbEntities())
                {
                    if (ModelState.IsValid)
                    {
                        subject.UpdateDt = DateTime.Now;
                        subject.CreateDt = DateTime.Now;
                        subject.IsDel = 0;
                        db.OrgInfo.Add(subject);
                        if (db.SaveChanges() > 0)
                        {

                            objResult = new ResultHelper()
                            {
                                Status = true,
                                Ret = 0,
                                Obj = subject,
                                Msg = "添加成功!",
                                Desc = "添加成功!"
                            };
                        }
                        else
                        {
                            objResult = new ResultHelper()
                            {
                                Desc = "添加失败,请重试.",
                                Msg = "添加失败,请重试.",
                                Obj = null,
                                Ret = -1,
                                Status = false
                            };
                        }
                    }
                    else
                    {
                        objResult = new ResultHelper()
                        {
                            Desc = "系统出错,请重试.",
                            Msg = "系统出错,请重试.",
                            Obj = null,
                            Ret = -1,
                            Status = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                objResult = new ResultHelper()
                {
                    Desc = ex.Message,
                    Msg = ex.Message,
                    Obj = null,
                    Ret = -1,
                    Status = false
                };
            }
            return Json(objResult);
        }

        /// <summary>
        /// 更新Org
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Modify(OrgInfo subject)
        {
            ResultHelper objResult = null;
            try
            {
                using (LedDbEntities db = new LedDbEntities())
                {
                    if (ModelState.IsValid)
                    {
                        OrgInfo aSubject = db.OrgInfo.Where(p => p.Id == subject.Id).FirstOrDefault();
                        aSubject.Name = subject.Name;
                        aSubject.ManageName=subject.ManageName;
                        aSubject.Address = subject.Address;
                        aSubject.ManageTel = subject.ManageTel;
                        aSubject.UpdateDt = DateTime.Now;
                        if (db.SaveChanges() > 0)
                        {

                            objResult = new ResultHelper()
                            {
                                Status = true,
                                Ret = 0,
                                Obj = subject,
                                Msg = "修改成功!",
                                Desc = "修改成功!"
                            };
                        }
                        else
                        {
                            objResult = new ResultHelper()
                            {
                                Desc = "修改失败,请重试.",
                                Msg = "修改失败,请重试.",
                                Obj = null,
                                Ret = -1,
                                Status = false
                            };
                        }
                    }
                    else
                    {
                        objResult = new ResultHelper()
                        {
                            Desc = "系统出错,请重试.",
                            Msg = "系统出错,请重试.",
                            Obj = null,
                            Ret = -1,
                            Status = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                objResult = new ResultHelper()
                {
                    Desc = ex.Message,
                    Msg = ex.Message,
                    Obj = null,
                    Ret = -1,
                    Status = false
                };
            }
            return Json(objResult);
        }


        /// <summary>
        /// 删除Org
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(string OrgIds)
        {
            ResultHelper objResult = null;
            try
            {
                using (LedDbEntities db = new LedDbEntities())
                {
                    if (ModelState.IsValid)
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.AppendFormat(@"UPDATE OrgInfo SET IsDel = 1 WHERE Id IN ({0})", OrgIds);
                        if (db.Database.ExecuteSqlCommand(strSql.ToString()) > 0)
                        {

                            objResult = new ResultHelper()
                            {
                                Status = true,
                                Ret = 0,
                                Obj = OrgIds,
                                Msg = "删除成功!",
                                Desc = "删除成功!"
                            };
                        }
                        else
                        {
                            objResult = new ResultHelper()
                            {
                                Desc = "删除失败,请重试.",
                                Msg = "删除失败,请重试.",
                                Obj = null,
                                Ret = -1,
                                Status = false
                            };
                        }
                    }
                    else
                    {
                        objResult = new ResultHelper()
                        {
                            Desc = "系统出错,请重试.",
                            Msg = "系统出错,请重试.",
                            Obj = null,
                            Ret = -1,
                            Status = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                objResult = new ResultHelper()
                {
                    Desc = ex.Message,
                    Msg = ex.Message,
                    Obj = null,
                    Ret = -1,
                    Status = false
                };
            }
            return Json(objResult);
        }

    }
}
