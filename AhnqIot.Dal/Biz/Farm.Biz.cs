﻿/*
 * XCoder v6.5.5847.16174
 * 作者：soft-cq/CQ-PC
 * 时间：2016-01-04 14:00:47
 * 版权：版权所有 (C) 安徽斯玛特物联网科技有限公司 2011~2016
 * http://www.smartah.cc
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using NewLife.Log;
using NewLife.Web;
using NewLife.Data;
using XCode;
using XCode.Configuration;
using XCode.Membership;

namespace AhnqIot.Dal
{
    /// <summary>企业基地</summary>
    public partial class Farm : Entity<Farm>
    {
        #region 对象操作
        
            

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew"></param>
        public override void Valid(Boolean isNew)
        {
			// 如果没有脏数据，则不需要进行任何处理
			if (!HasDirty) return;

            // 这里验证参数范围，建议抛出参数异常，指定参数名，前端用户界面可以捕获参数异常并聚焦到对应的参数输入框
            //if (String.IsNullOrEmpty(Name)) throw new ArgumentNullException(_.Name, _.Name.DisplayName + "无效！");
            //if (!isNew && ID < 1) throw new ArgumentOutOfRangeException(_.ID, _.ID.DisplayName + "必须大于0！");

            // 建议先调用基类方法，基类方法会对唯一索引的数据进行验证
            base.Valid(isNew);

            // 在新插入数据或者修改了指定字段时进行唯一性验证，CheckExist内部抛出参数异常
            //if (isNew || Dirtys[__.Name]) CheckExist(__.Name);
            
            if (isNew && !Dirtys[__.CreateTime]) CreateTime = DateTime.Now;
            if (!Dirtys[__.UpdateTime]) UpdateTime = DateTime.Now;
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    base.InitData();

        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    // Meta.Count是快速取得表记录数
        //    if (Meta.Count > 0) return;

        //    // 需要注意的是，如果该方法调用了其它实体类的首次数据库操作，目标实体类的数据初始化将会在同一个线程完成
        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化{0}[{1}]数据……", typeof(Farm).Name, Meta.Table.DataTable.DisplayName);

        //    var entity = new Farm();
        //    entity.Serialnum = "abc";
        //    entity.CreateTime = DateTime.Now;
        //    entity.CreateSysUserSerialnum = "abc";
        //    entity.UpdateTime = DateTime.Now;
        //    entity.UpdateSysUserSerialnum = "abc";
        //    entity.Name = "abc";
        //    entity.SysDepartmentSerialnum = "abc";
        //    entity.CompanySerialnum = "abc";
        //    entity.AreaStationSerialnum = "abc";
        //    entity.UploadPassword = "abc";
        //    entity.APIKey = "abc";
        //    entity.Address = "abc";
        //    entity.Location = "abc";
        //    entity.Lotitude = "abc";
        //    entity.Latitude = "abc";
        //    entity.Introduce = "abc";
        //    entity.PhotoUrl = "abc";
        //    entity.ContactMan = "abc";
        //    entity.ContactPhone = "abc";
        //    entity.Status = true;
        //    entity.Sort = 0;
        //    entity.Remark = "abc";
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化{0}[{1}]数据！", typeof(Farm).Name, Meta.Table.DataTable.DisplayName);
        //}

        /// <summary>已重载。删除关联数据</summary>
        /// <returns></returns>
        protected override int OnDelete()
        {
            if (CompanyUsers != null) CompanyUsers.Delete();
            if (Facilitys != null) Facilitys.Delete();

            return base.OnDelete();
        }

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnInsert()
        //{
        //    return base.OnInsert();
        //}

            
        #endregion

        #region 扩展属性
        
            
        [NonSerialized]
        private EntityList<CompanyUser> _CompanyUsers;
        /// <summary>该企业基地所拥有的企业用户集合</summary>
        [XmlIgnore]
        public EntityList<CompanyUser> CompanyUsers
        {
            get
            {
                if (_CompanyUsers == null && !String.IsNullOrEmpty(Serialnum) && !Dirtys.ContainsKey("CompanyUsers"))
                {
                    _CompanyUsers = CompanyUser.FindAllByFarmSerialnum(Serialnum);
                    Dirtys["CompanyUsers"] = true;
                }
                return _CompanyUsers;
            }
            set { _CompanyUsers = value; }
        }

        [NonSerialized]
        private EntityList<Facility> _Facilitys;
        /// <summary>该企业基地所拥有的基地设施集合</summary>
        [XmlIgnore]
        public EntityList<Facility> Facilitys
        {
            get
            {
                if (_Facilitys == null && !String.IsNullOrEmpty(Serialnum) && !Dirtys.ContainsKey("Facilitys"))
                {
                    _Facilitys = Facility.FindAllByFarmSerialnum(Serialnum);
                    Dirtys["Facilitys"] = true;
                }
                return _Facilitys;
            }
            set { _Facilitys = value; }
        }

        [NonSerialized]
        private AreaStation _AreaStation;
        /// <summary>该企业基地所对应的基地关联气象站</summary>
        [XmlIgnore]
        public AreaStation AreaStation
        {
            get
            {
                if (_AreaStation == null && !String.IsNullOrEmpty(AreaStationSerialnum) && !Dirtys.ContainsKey("AreaStation"))
                {
                    _AreaStation = AreaStation.FindBySerialnum(AreaStationSerialnum);
                    Dirtys["AreaStation"] = true;
                }
                return _AreaStation;
            }
            set { _AreaStation = value; }
        }

        [NonSerialized]
        private Company _Company;
        /// <summary>该企业基地所对应的企业</summary>
        [XmlIgnore]
        public Company Company
        {
            get
            {
                if (_Company == null && !String.IsNullOrEmpty(CompanySerialnum) && !Dirtys.ContainsKey("Company"))
                {
                    _Company = Company.FindBySerialnum(CompanySerialnum);
                    Dirtys["Company"] = true;
                }
                return _Company;
            }
            set { _Company = value; }
        }

        /// <summary>该企业基地所对应的企业名称</summary>
        [XmlIgnore]
        public String CompanyName { get { return Company != null ? Company.Name : String.Empty; } }

        [NonSerialized]
        private SysDepartment _SysDepartment;
        /// <summary>该企业基地所对应的机构管理</summary>
        [XmlIgnore]
        public SysDepartment SysDepartment
        {
            get
            {
                if (_SysDepartment == null && !String.IsNullOrEmpty(SysDepartmentSerialnum) && !Dirtys.ContainsKey("SysDepartment"))
                {
                    _SysDepartment = SysDepartment.FindBySerialnum(SysDepartmentSerialnum);
                    Dirtys["SysDepartment"] = true;
                }
                return _SysDepartment;
            }
            set { _SysDepartment = value; }
        }

        /// <summary>该企业基地所对应的机构管理机构名称</summary>
        [XmlIgnore]
        public String SysDepartmentName { get { return SysDepartment != null ? SysDepartment.Name : String.Empty; } }

            
        #endregion

        #region 扩展查询
        
            
        /// <summary>根据企业查找</summary>
        /// <param name="companyserialnum">企业</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static EntityList<Farm> FindAllByCompanySerialnum(String companyserialnum)
        {
            if (Meta.Count >= 1000)
                return FindAll(__.CompanySerialnum, companyserialnum);
            else // 实体缓存
                return Meta.Cache.Entities.FindAll(__.CompanySerialnum, companyserialnum);
        }

        /// <summary>根据机构查找</summary>
        /// <param name="sysdepartmentserialnum">机构</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static EntityList<Farm> FindAllBySysDepartmentSerialnum(String sysdepartmentserialnum)
        {
            if (Meta.Count >= 1000)
                return FindAll(__.SysDepartmentSerialnum, sysdepartmentserialnum);
            else // 实体缓存
                return Meta.Cache.Entities.FindAll(__.SysDepartmentSerialnum, sysdepartmentserialnum);
        }

        /// <summary>根据关联气象站查找</summary>
        /// <param name="areastationserialnum">关联气象站</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static EntityList<Farm> FindAllByAreaStationSerialnum(String areastationserialnum)
        {
            if (Meta.Count >= 1000)
                return FindAll(__.AreaStationSerialnum, areastationserialnum);
            else // 实体缓存
                return Meta.Cache.Entities.FindAll(__.AreaStationSerialnum, areastationserialnum);
        }

        /// <summary>根据编码查找</summary>
        /// <param name="serialnum">编码</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static Farm FindBySerialnum(String serialnum)
        {
            if (Meta.Count >= 1000)
                return Find(__.Serialnum, serialnum);
            else // 实体缓存
                return Meta.Cache.Entities.Find(__.Serialnum, serialnum);
            // 单对象缓存
            //return Meta.SingleCache[serialnum];
        }

            
        #endregion

        #region 高级查询
        
        // 以下为自定义高级查询的例子
        /// <summary>查询满足条件的记录集，分页、排序</summary>
        /// <param name="userid">用户编号</param>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="key">关键字</param>
        /// <param name="param">分页排序参数，同时返回满足条件的总记录数</param>
        /// <returns>实体集</returns>
        public static EntityList<Farm> Search(Int32 userid, DateTime start, DateTime end, String key, PageParameter param)
        {
            // WhereExpression重载&和|运算符，作为And和Or的替代
            // SearchWhereByKeys系列方法用于构建针对字符串字段的模糊搜索，第二个参数可指定要搜索的字段
            var exp = SearchWhereByKeys(key, null, null);

            // 以下仅为演示，Field（继承自FieldItem）重载了==、!=、>、<、>=、<=等运算符
            //if (userid > 0) exp &= _.OperatorID == userid;
            //if (isSign != null) exp &= _.IsSign == isSign.Value;
            //exp &= _.OccurTime.Between(start, end); // 大于等于start，小于end，当start/end大于MinValue时有效

            return FindAll(exp, param);
        }
        
        #endregion
    }
}