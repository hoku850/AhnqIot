﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8670
//     Support: http://www.cnblogs.com/huxj
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;


namespace AhnqIot.Hxj.DbModel
{

	/// <summary>
	/// 实体类AreaStationDataInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class AreaStationDataInfo : Entity 
	{
		public AreaStationDataInfo():base("AreaStationDataInfo") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private DateTime _UpdateTime;
		private string _AreaStationSerialnum;
		private decimal _Temprature;
		private decimal _Humidity;
		private decimal _Rainfall;
		private decimal _WindSpeed;
		private int _WindDirection;
		private decimal _Atmosphere;
		private string _Remark;
		private int _Sort;
		private string _CreateSysUserSerialnum;
		private string _UpdateSysUserSerialnum;
		/// <summary>
		/// 编码
		/// </summary>
		public string Serialnum
		{
			get{ return _Serialnum; }
			set
			{
				this.OnPropertyValueChange(_.Serialnum,_Serialnum,value);
				this._Serialnum=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		/// <summary>
		/// 数据时间
		/// </summary>
		public DateTime UpdateTime
		{
			get{ return _UpdateTime; }
			set
			{
				this.OnPropertyValueChange(_.UpdateTime,_UpdateTime,value);
				this._UpdateTime=value;
			}
		}
		/// <summary>
		/// 区域气象站
		/// </summary>
		public string AreaStationSerialnum
		{
			get{ return _AreaStationSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.AreaStationSerialnum,_AreaStationSerialnum,value);
				this._AreaStationSerialnum=value;
			}
		}
		/// <summary>
		/// 温度
		/// </summary>
		public decimal Temprature
		{
			get{ return _Temprature; }
			set
			{
				this.OnPropertyValueChange(_.Temprature,_Temprature,value);
				this._Temprature=value;
			}
		}
		/// <summary>
		/// 湿度
		/// </summary>
		public decimal Humidity
		{
			get{ return _Humidity; }
			set
			{
				this.OnPropertyValueChange(_.Humidity,_Humidity,value);
				this._Humidity=value;
			}
		}
		/// <summary>
		/// 降雨量
		/// </summary>
		public decimal Rainfall
		{
			get{ return _Rainfall; }
			set
			{
				this.OnPropertyValueChange(_.Rainfall,_Rainfall,value);
				this._Rainfall=value;
			}
		}
		/// <summary>
		/// 风速
		/// </summary>
		public decimal WindSpeed
		{
			get{ return _WindSpeed; }
			set
			{
				this.OnPropertyValueChange(_.WindSpeed,_WindSpeed,value);
				this._WindSpeed=value;
			}
		}
		/// <summary>
		/// 风向
		/// </summary>
		public int WindDirection
		{
			get{ return _WindDirection; }
			set
			{
				this.OnPropertyValueChange(_.WindDirection,_WindDirection,value);
				this._WindDirection=value;
			}
		}
		/// <summary>
		/// 大气压
		/// </summary>
		public decimal Atmosphere
		{
			get{ return _Atmosphere; }
			set
			{
				this.OnPropertyValueChange(_.Atmosphere,_Atmosphere,value);
				this._Atmosphere=value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateSysUserSerialnum
		{
			get{ return _CreateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CreateSysUserSerialnum,_CreateSysUserSerialnum,value);
				this._CreateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpdateSysUserSerialnum
		{
			get{ return _UpdateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.UpdateSysUserSerialnum,_UpdateSysUserSerialnum,value);
				this._UpdateSysUserSerialnum=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Serialnum};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Serialnum,
				_.CreateTime,
				_.UpdateTime,
				_.AreaStationSerialnum,
				_.Temprature,
				_.Humidity,
				_.Rainfall,
				_.WindSpeed,
				_.WindDirection,
				_.Atmosphere,
				_.Remark,
				_.Sort,
				_.CreateSysUserSerialnum,
				_.UpdateSysUserSerialnum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Serialnum,
				this._CreateTime,
				this._UpdateTime,
				this._AreaStationSerialnum,
				this._Temprature,
				this._Humidity,
				this._Rainfall,
				this._WindSpeed,
				this._WindDirection,
				this._Atmosphere,
				this._Remark,
				this._Sort,
				this._CreateSysUserSerialnum,
				this._UpdateSysUserSerialnum};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(reader["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(reader["UpdateTime"]);
			this._AreaStationSerialnum = DataUtils.ConvertValue<string>(reader["AreaStationSerialnum"]);
			this._Temprature = DataUtils.ConvertValue<decimal>(reader["Temprature"]);
			this._Humidity = DataUtils.ConvertValue<decimal>(reader["Humidity"]);
			this._Rainfall = DataUtils.ConvertValue<decimal>(reader["Rainfall"]);
			this._WindSpeed = DataUtils.ConvertValue<decimal>(reader["WindSpeed"]);
			this._WindDirection = DataUtils.ConvertValue<int>(reader["WindDirection"]);
			this._Atmosphere = DataUtils.ConvertValue<decimal>(reader["Atmosphere"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
			this._Sort = DataUtils.ConvertValue<int>(reader["Sort"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["CreateSysUserSerialnum"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["UpdateSysUserSerialnum"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(row["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(row["UpdateTime"]);
			this._AreaStationSerialnum = DataUtils.ConvertValue<string>(row["AreaStationSerialnum"]);
			this._Temprature = DataUtils.ConvertValue<decimal>(row["Temprature"]);
			this._Humidity = DataUtils.ConvertValue<decimal>(row["Humidity"]);
			this._Rainfall = DataUtils.ConvertValue<decimal>(row["Rainfall"]);
			this._WindSpeed = DataUtils.ConvertValue<decimal>(row["WindSpeed"]);
			this._WindDirection = DataUtils.ConvertValue<int>(row["WindDirection"]);
			this._Atmosphere = DataUtils.ConvertValue<decimal>(row["Atmosphere"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
			this._Sort = DataUtils.ConvertValue<int>(row["Sort"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(row["CreateSysUserSerialnum"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(row["UpdateSysUserSerialnum"]);
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","AreaStationDataInfo");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","AreaStationDataInfo","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","AreaStationDataInfo","创建时间");
			/// <summary>
			/// 数据时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","AreaStationDataInfo","数据时间");
			/// <summary>
			/// 区域气象站
			/// </summary>
			public readonly static Field AreaStationSerialnum = new Field("AreaStationSerialnum","AreaStationDataInfo","区域气象站");
			/// <summary>
			/// 温度
			/// </summary>
			public readonly static Field Temprature = new Field("Temprature","AreaStationDataInfo","温度");
			/// <summary>
			/// 湿度
			/// </summary>
			public readonly static Field Humidity = new Field("Humidity","AreaStationDataInfo","湿度");
			/// <summary>
			/// 降雨量
			/// </summary>
			public readonly static Field Rainfall = new Field("Rainfall","AreaStationDataInfo","降雨量");
			/// <summary>
			/// 风速
			/// </summary>
			public readonly static Field WindSpeed = new Field("WindSpeed","AreaStationDataInfo","风速");
			/// <summary>
			/// 风向
			/// </summary>
			public readonly static Field WindDirection = new Field("WindDirection","AreaStationDataInfo","风向");
			/// <summary>
			/// 大气压
			/// </summary>
			public readonly static Field Atmosphere = new Field("Atmosphere","AreaStationDataInfo","大气压");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","AreaStationDataInfo","备注");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","AreaStationDataInfo","排序");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","AreaStationDataInfo","CreateSysUserSerialnum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","AreaStationDataInfo","UpdateSysUserSerialnum");
		}
		#endregion


	}
}

