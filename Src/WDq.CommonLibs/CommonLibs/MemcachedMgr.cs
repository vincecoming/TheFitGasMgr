﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemcachedProviders.Cache;

namespace PiPublic
{
    public class MemcachedMgr
    {
        public static string strKeyTest = "mem_key_test_001-34324";
        public static string GetVal(string strKey)
        {
            object obj = DistCache.Get(strKey);
            if (obj!=null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }
        }
        public static bool SetVal(string strKey, string strVal)
        {            
            return DistCache.Add(strKey, strVal);
        }

        public static void RemoveKey(string strKey)
        {
            DistCache.Remove(strKey);
        }



        /// <summary>
        ///  演示如何使用
        /// </summary>
        public static void Demo()
        {
            string strVal = "val_23432";
            string strKey = "sdflsstrkeysdfjj0495340580jritu50ejkldsfgjfp9jdklstu34";
            SetVal(strKey, strVal);
            string strValRead = GetVal(strKey);

            //
            // obj
            //
            MemcachedTestObjDef objval = new MemcachedTestObjDef()
            {
                id = 1,
                strVal = "val_sdfds"
            };
            string strObjVal = PiPublic.JsonStrObjConver.Obj2JsonStr(objval, typeof(MemcachedTestObjDef));
            SetVal(strKey, strObjVal);
            string strObjValRead = GetVal(strKey);
            MemcachedTestObjDef objvalread = PiPublic.JsonStrObjConver.JsonStr2Obj(strObjVal, typeof(MemcachedTestObjDef)) as MemcachedTestObjDef;            
        }
        class MemcachedTestObjDef
        {
            public int id { get; set; }
            public string strVal{ get; set; }
        }
    }
}
