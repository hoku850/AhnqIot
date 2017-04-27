﻿/*
 * XCoder v6.5.5660.22154
 * 作者：soft-cq/CQ-PC
 * 时间：2015-08-02 20:28:32
 * 版权：版权所有 (C) 新生命开发团队 2002~2015
*/

using NewLife.Data;
using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;
using XCode;

namespace SmartIot.Tool.DefaultService.DB
{
    /// <summary>设施传感器设备</summary>
    [ModelCheckMode(ModelCheckModes.CheckTableWhenFirstUse)]
    public class FacilitySensorDeviceUnit : FacilitySensorDeviceUnit<FacilitySensorDeviceUnit>
    {
    }

    /// <summary>设施传感器设备</summary>
    public partial class FacilitySensorDeviceUnit<TEntity> : LogEntity<TEntity>
        where TEntity : FacilitySensorDeviceUnit<TEntity>, new()
    {
        #region 高级查询

        // 以下为自定义高级查询的例子

        /// <summary>查询满足条件的记录集，分页、排序</summary>
        /// <param name="userid">用户编号</param>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="key">关键字</param>
        /// <param name="param">分页排序参数，同时返回满足条件的总记录数</param>
        /// <returns>实体集</returns>
        public static EntityList<TEntity> Search(Int32 userid, DateTime start, DateTime end, String key,
            PageParameter param)
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

        #endregion 高级查询

        #region 扩展操作

        public static int DeleteByFacilityAndSensorDeviceunit(int facilityId, int deviceID)
        {
            return Delete(new string[] {_.FacilityID, _.SensorDeviceUnitID}, new object[] {facilityId, deviceID});
        }

        #endregion 扩展操作

        #region 对象操作

        static FacilitySensorDeviceUnit()
        {
            // 用于引发基类的静态构造函数，所有层次的泛型实体类都应该有一个
            var entity = new TEntity();
        }

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
        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化{0}[{1}]数据……", typeof(TEntity).Name, Meta.Table.DataTable.DisplayName);

        //    var entity = new FacilitySensorDeviceUnit();
        //    entity.ID = 0;
        //    entity.Name = "abc";
        //    entity.Code1 = "abc";
        //    entity.Code2 = "abc";
        //    entity.Code3 = "abc";
        //    entity.FacilityID = 0;
        //    entity.SensorDeviceUnitID = 0;
        //    entity.Upload = true;
        //    entity.Version = 0;
        //    entity.Remark = "abc";
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化{0}[{1}]数据！", typeof(TEntity).Name, Meta.Table.DataTable.DisplayName);
        //}

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

        #endregion 对象操作

        #region 扩展属性

        [NonSerialized] private Facility _Facility;

        /// <summary>该设施传感器设备所对应的基地设施</summary>
        [XmlIgnore]
        public Facility Facility
        {
            get
            {
                if (_Facility == null && FacilityID > 0 && !Dirtys.ContainsKey("Facility"))
                {
                    _Facility = Facility.FindByID(FacilityID);
                    Dirtys["Facility"] = true;
                }
                return _Facility;
            }
            set { _Facility = value; }
        }

        /// <summary>该设施传感器设备所对应的基地设施名称</summary>
        [XmlIgnore]
        public String FacilityName
        {
            get { return Facility != null ? Facility.Name : String.Empty; }
        }

        [NonSerialized] private SensorDeviceUnit _SensorDeviceUnit;

        /// <summary>该设施传感器设备所对应的传感器设备</summary>
        [XmlIgnore]
        public SensorDeviceUnit SensorDeviceUnit
        {
            get
            {
                if (_SensorDeviceUnit == null && SensorDeviceUnitID > 0 && !Dirtys.ContainsKey("SensorDeviceUnit"))
                {
                    _SensorDeviceUnit = SensorDeviceUnit.FindByID(SensorDeviceUnitID);
                    Dirtys["SensorDeviceUnit"] = true;
                }
                return _SensorDeviceUnit;
            }
            set { _SensorDeviceUnit = value; }
        }

        /// <summary>该设施传感器设备所对应的传感器设备设备名称</summary>
        [XmlIgnore]
        public String SensorDeviceUnitName
        {
            get { return SensorDeviceUnit != null ? SensorDeviceUnit.Name : String.Empty; }
        }

        #endregion 扩展属性

        #region 扩展查询

        /// <summary>根据ID查找</summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static TEntity FindByID(Int32 id)
        {
            if (Meta.Count >= 1000)
                return Find(__.ID, id);
            else // 实体缓存
                return Meta.Cache.Entities.Find(__.ID, id);
            // 单对象缓存
            //return Meta.SingleCache[id];
        }

        /// <summary>根据设施查找</summary>
        /// <param name="facilityid">设施</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static EntityList<TEntity> FindAllByFacilityID(Int32 facilityid)
        {
            if (Meta.Count >= 1000)
                return FindAll(__.FacilityID, facilityid);
            else // 实体缓存
                return Meta.Cache.Entities.FindAll(__.FacilityID, facilityid);
        }

        /// <summary>根据传感器设备查找</summary>
        /// <param name="sensordeviceunitid">传感器设备</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public static EntityList<TEntity> FindAllBySensorDeviceUnitID(Int32 sensordeviceunitid)
        {
            if (Meta.Count >= 1000)
                return FindAll(__.SensorDeviceUnitID, sensordeviceunitid);
            else // 实体缓存
                return Meta.Cache.Entities.FindAll(__.SensorDeviceUnitID, sensordeviceunitid);
        }

        public static EntityList<TEntity> FindAllByFacilityIdAndCollectDeviceId(int facilityId, int collectDeviceId)
        {
            if (Meta.Count >= 1000)
                return FindAll(
                    new string[] {__.SensorDeviceUnitID, __.FacilityID},
                    new object[] {collectDeviceId, facilityId});
            else // 实体缓存
                return
                    Meta.Cache.Entities.FindAll(
                        e => e.FacilityID == facilityId && e.SensorDeviceUnitID == collectDeviceId);
        }

        /// <summary>
        /// 根据设施Id和采集设备Id查找
        /// </summary>
        /// <param name="facilityId">设施Id</param>
        /// <param name="collectDeviceId">采集设备Id</param>
        /// <returns></returns>
        public static bool GetDeviceByFacilityIdAndCollectDeviceId(int facilityId, int collectDeviceId)
        {
            var b = false;
            var list1 = FindAllBySensorDeviceUnitID(collectDeviceId).ToList(); //根据采集设备Id查找的设施采集设备
            var list2 = FindAllByFacilityID(facilityId).ToList(); //根据设施Id查找的设施采集设备
            foreach (var collect1 in list1)
            {
                foreach (var collect2 in list2)
                {
                    if (collect1._FacilityID == collect2.FacilityID &&
                        collect1.SensorDeviceUnitID == collect2.SensorDeviceUnitID)
                    {
                        b = true;
                    }
                }
            }
            return b;
        }

        #endregion 扩展查询

        #region 业务

        public String GetCode1()
        {
            var facility = Facility.FindByID(FacilityID);
            var list =
                FacilitySensorDeviceUnit.FindAllByFacilityID(facility.ID)
                    .ToList()
                    .Where(e => !e.Code1.IsNullOrWhiteSpace())
                    .OrderByDescending(e => e.Code1);
            var isNew = this.ID < 0;
            if (isNew)
            {
                if (list.Any())
                {
                    var entity = list.ElementAt(0);
                    if (!entity.Code1.IsNullOrWhiteSpace())
                        return facility.Code1 + "C" +
                               (Convert.ToInt32(
                                   entity.Code1.Replace(entity.Code1.Substring(0, facility.Code1.Length) + "C", "")) + 1)
                                   .ToString().PadLeft(3, '0');
                }
            }
            else
            {
                if (list.Any())
                {
                    var entity = list.ElementAt(0);
                    if (!entity.Code1.IsNullOrWhiteSpace())
                        if (!entity.Code1.StartsWith(facility.Code1))
                        {
                            return entity.Code1.Replace(entity.Code1.Substring(0, facility.Code1.Length), facility.Code1);
                        }
                        else
                        {
                            return facility.Code1 + "C" +
                                   (Convert.ToInt32(
                                       entity.Code1.Replace(entity.Code1.Substring(0, facility.Code1.Length) + "C", "")) +
                                    1).ToString().PadLeft(3, '0');
                        }
                }
            }
            return facility.Code1 + "C" + 1.ToString().PadLeft(3, '0');
        }

        public static String GetCode1(int facilityId)
        {
            var facility = Facility.FindByID(facilityId);

            var list = FindAll(_.FacilityID, facilityId);
            if (list.Count > 0)
            {
                var entity = list[0];
                if (!entity.Code1.IsNullOrWhiteSpace())
                    if (!entity.Code1.StartsWith(facility.Code1))
                    {
                        return entity.Code1.Replace(entity.Code1.Substring(0, facility.Code1.Length), facility.Code1);
                    }
                    else
                    {
                        return facility.Code1 + "C" +
                               (Convert.ToInt32(
                                   entity.Code1.Replace(entity.Code1.Substring(0, facility.Code1.Length) + "C", "")) + 1)
                                   .ToString().PadLeft(3, '0');
                    }
                //return facility.Code1 + "C" + 1.ToString().PadLeft(3, '0');
            }
            return facility.Code1 + "C" + 1.ToString().PadLeft(3, '0');
        }

        public static String GetCode2(int facilityId)
        {
            var facility = Facility.FindByID(facilityId);

            var list = FindAll(_.FacilityID, facilityId);
            if (list.Count > 0)
            {
                var entity = list[0];
                if (!entity.Code2.IsNullOrWhiteSpace())

                    return facility.Code2 + "C" +
                           (Convert.ToInt32(entity.Code2.Replace(facility.Code2 + "C", "")) + 1).ToString()
                               .PadLeft(3, '0');
            }
            return facility.Code2 + "C" + 1.ToString().PadLeft(3, '0');
        }

        public static String GetCode3(int facilityId)
        {
            var facility = Facility.FindByID(facilityId);

            var list = FindAll(_.FacilityID, facilityId);
            {
                var entity = list[0];
                if (!entity.Code2.IsNullOrWhiteSpace())

                    return facility.Code3 + "C" +
                           (Convert.ToInt32(entity.Code2.Replace(facility.Code3 + "C", "")) + 1).ToString()
                               .PadLeft(3, '0');
            }
            return facility.Code3 + "C" + 1.ToString().PadLeft(3, '0');
        }

        #endregion 业务
    }
}