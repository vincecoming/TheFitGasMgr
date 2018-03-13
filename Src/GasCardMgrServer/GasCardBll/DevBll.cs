﻿///<summary>
///Copyright (c) 2015, 珠海派诺科技股份有限公司
///Product: PiEMS
///
///文件名称: DevBll.cs
///开发环境: Microsoft Visual Studio 2010
///描    述：
///
///当前版本: V1.0
///作    者: Wudq
///完成日期: 2016-03-24 7:36:22
///
///修改记录 
/// 作者   时间    版本      修改描述
///
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

#if SQL_SERVER
using NetLabelEfDbDll.SqlServer;
using Models;
#endif


namespace NetLabelBll
{
    /// <summary>
    /// 设备管理,增删改查
    /// </summary>
    public class DevBll
    {
        /// <summary>
        /// 获取所有的设备
        /// </summary>        
        /// <returns></returns>
        public static List<DevInfoModel> GetAllDev()
        {
            List<DevInfoModel> lstMods = new List<DevInfoModel>();
            using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
            {
                List<DevInfo> devs = (from c in ent.DevInfo
                                      select c).ToList<DevInfo>();
                foreach (DevInfo dev in devs)
                {
                    DevInfoModel mod = new DevInfoModel()
                    {
                        Adress = dev.Address,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = (int)dev.GatewayId,
                        GroupId = (int)dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = (int)dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = (int)dev.ProjectId,
                        RangeId = (int)dev.RangeId,
                        DevLineIndex = (int)dev.LineIndex,
                        Status = (int)dev.Status
                    };
                    lstMods.Add(mod);
                }
            }

            return lstMods;
        }

        /// <summary>
        /// 通过网关ID获取设备
        /// </summary>
        /// <param name="iGwId"></param>
        /// <returns></returns>
        public static List<DevInfoModel> GetDevByGwId(int iGwId)
        {
            List<DevInfoModel> lstMods = new List<DevInfoModel>();
            using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
            {
                List<DevInfo> devs = (from c in ent.DevInfo
                                      where c.GatewayId == iGwId
                                      select c).ToList<DevInfo>();
                foreach (DevInfo dev in devs)
                {
                    DevInfoModel mod = new DevInfoModel()
                    {
                        Adress = dev.Address,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = (int)dev.GatewayId,
                        GroupId = (int)dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = (int)dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = (int)dev.ProjectId,
                        RangeId = (int)dev.RangeId,
                        DevLineIndex = (int)dev.LineIndex,
                        Status = (int)dev.Status
                    };
                    lstMods.Add(mod);
                }
            }

            return lstMods;
        }

        /// <summary>
        /// 项目组ID获取设备
        /// </summary>
        /// <param name="iGwId"></param>
        /// <returns></returns>
        public static List<DevInfoModel> GetDevByGroupId(int iGwId)
        {
            List<DevInfoModel> lstMods = new List<DevInfoModel>();
            using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
            {
                List<DevInfo> devs = (from c in ent.DevInfo 
                                      where c.GroupId == iGwId 
                                      select c).ToList<DevInfo>();
                foreach (DevInfo dev in devs)
                {
                    DevInfoModel mod = new DevInfoModel()
                    {
                        Adress = dev.Address,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = (int)dev.GatewayId,
                        GroupId = (int)dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = (int)dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = (int)dev.ProjectId,
                        RangeId = (int)dev.RangeId,
                        DevLineIndex = (int)dev.LineIndex,
                        Status = (int)dev.Status
                    };
                    lstMods.Add(mod);
                }
            }

            return lstMods;
        }


        /// <summary>
        /// 项目组ID获取设备
        /// </summary>
        /// <param name="iGwId"></param>
        /// <returns></returns>
        public static List<DevInfoModel> GetDevByProjectId(int iProjId)
        {
            List<DevInfoModel> lstMods = new List<DevInfoModel>();
            using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
            {
                List<DevInfo> devs = (from c in ent.DevInfo
                                      where c.ProjectId == iProjId
                                      select c).ToList<DevInfo>();
                foreach (DevInfo dev in devs)
                {
                    DevInfoModel mod = new DevInfoModel()
                    {
                        Adress = dev.Address,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = (int)dev.GatewayId,
                        GroupId = (int)dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = (int)dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = (int)dev.ProjectId,
                        RangeId = (int)dev.RangeId,
                        DevLineIndex = (int)dev.LineIndex,
                        Status = (int)dev.Status
                    };
                    lstMods.Add(mod);
                }
            }

            return lstMods;
        }

        /// <summary>
        /// 项目组ID获取设备
        /// </summary>
        /// <param name="iGwId"></param>
        /// <returns></returns>
        public static List<DevInfoModel> GetDevByRangeId(int iRangeId)
        {
            List<DevInfoModel> lstMods = new List<DevInfoModel>();
            using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
            {
                List<DevInfo> devs = (from c in ent.DevInfo
                                      where c.RangeId == iRangeId
                                      select c).ToList<DevInfo>();
                foreach (DevInfo dev in devs)
                {
                    DevInfoModel mod = new DevInfoModel()
                    {
                        Adress = dev.Address,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = (int)dev.GatewayId,
                        GroupId = (int)dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = (int)dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = (int)dev.ProjectId,
                        RangeId = (int)dev.RangeId,
                        DevLineIndex = (int)dev.LineIndex,
                        Status = (int)dev.Status
                    };
                    lstMods.Add(mod);
                }
            }

            return lstMods;
        }

        public static bool AddDev(ref DevInfoModel dev, out string strError)
        {
            strError = "";
            try
            {
                using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
                {
                    DevInfo objdev = new DevInfo()
                    {
                        Address = dev.Adress,
                        Address_GPS = dev.Address_GPS,
                        DevAddr = dev.DevAddr,
                        DevType = dev.DevType,
                        GatewayId = dev.GatewayId,
                        GroupId = dev.GroupId,
                        ID = dev.ID,
                        Name = dev.Name,
                        OrgId = dev.OrgId,
                        PosInfo = dev.PosInfo,
                        ProjectId = dev.ProjectId,
                        RangeId = dev.RangeId,
                        LineIndex = dev.DevLineIndex,
                        Status = (int)dev.Status
                    };

                    ent.DevInfo.AddObject(objdev);
                    ent.SaveChanges();
                    dev.ID = objdev.ID;
                    return true;
                }
     
            }
            catch (System.Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public static bool AddNode(NodeInfoModel node, out string strError)
        {
            strError = "";
            try
            {
                using (CellLedLabelMgrDBEntities ent = new CellLedLabelMgrDBEntities())
                {
                    NodeInfo obj = new NodeInfo()
                    {
                        DevId = node.DevId,
                        FunCode = node.strFuncCode,
                        ID = node.ID,
                        Name = node.Name,
                        ResAddress = node.strAddr,
                        ValueCatalog1 = node.strCatalog1,
                        ValueCatalog2 = node.strCatalog2,
                    };


                    ent.NodeInfo.AddObject(obj);
                    ent.SaveChanges();
                    node.ID = obj.ID;
                    return true;
                }

            }
            catch (System.Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
    }
}