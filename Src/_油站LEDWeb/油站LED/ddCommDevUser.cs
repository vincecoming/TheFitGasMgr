//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OilStationLED
{
    using System;
    using System.Collections.Generic;
    
    public partial class ddCommDevUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> MgrCommDevId { get; set; }
        public Nullable<int> RefOrgId { get; set; }
        public Nullable<int> RefGroupId { get; set; }
        public Nullable<int> RefProjectId { get; set; }
        public Nullable<int> IsDel { get; set; }
        public Nullable<System.DateTime> CreateDt { get; set; }
        public Nullable<System.DateTime> UpdateDt { get; set; }
    }
}
