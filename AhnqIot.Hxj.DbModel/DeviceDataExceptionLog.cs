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
	/// 实体类DeviceDataExceptionLog 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DeviceDataExceptionLog : Entity 
	{
		public DeviceDataExceptionLog():base("DeviceDataExceptionLog") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _DeviceSerialnum;
		private decimal _Value;
		private int _Status;
		private decimal _Max;
		private decimal _Min;
		private int _Sort;
		private string _Remark;
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
		/// 创建用户
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
		/// 更新时间
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
		/// 更新用户
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
		/// <summary>
		/// 设备编码
		/// </summary>
		public string DeviceSerialnum
		{
			get{ return _DeviceSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.DeviceSerialnum,_DeviceSerialnum,value);
				this._DeviceSerialnum=value;
			}
		}
		/// <summary>
		/// 设备值
		/// </summary>
		public decimal Value
		{
			get{ return _Value; }
			set
			{
				this.OnPropertyValueChange(_.Value,_Value,value);
				this._Value=value;
			}
		}
		/// <summary>
		/// 异常类型（1：偏大，-1：偏小）
		/// </summary>
		public int Status
		{
			get{ return _Status; }
			set
			{
				this.OnPropertyValueChange(_.Status,_Status,value);
				this._Status=value;
			}
		}
		/// <summary>
		/// 上限
		/// </summary>
		public decimal Max
		{
			get{ return _Max; }
			set
			{
				this.OnPropertyValueChange(_.Max,_Max,value);
				this._Max=value;
			}
		}
		/// <summary>
		/// 下限
		/// </summary>
		public decimal Min
		{
			get{ return _Min; }
			set
			{
				this.OnPropertyValueChange(_.Min,_Min,value);
				this._Min=value;
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
				_.CreateSysUserSerialnum,
				_.UpdateTime,
				_.UpdateSysUserSerialnum,
				_.DeviceSerialnum,
				_.Value,
				_.Status,
				_.Max,
				_.Min,
				_.Sort,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Serialnum,
				this._CreateTime,
				this._CreateSysUserSerialnum,
				this._UpdateTime,
				this._UpdateSysUserSerialnum,
				this._DeviceSerialnum,
				this._Value,
				this._Status,
				this._Max,
				this._Min,
				this._Sort,
				this._Remark};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(reader["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(reader["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["UpdateSysUserSerialnum"]);
			this._DeviceSerialnum = DataUtils.ConvertValue<string>(reader["DeviceSerialnum"]);
			this._Value = DataUtils.ConvertValue<decimal>(reader["Value"]);
			this._Status = DataUtils.ConvertValue<int>(reader["Status"]);
			this._Max = DataUtils.ConvertValue<decimal>(reader["Max"]);
			this._Min = DataUtils.ConvertValue<decimal>(reader["Min"]);
			this._Sort = DataUtils.ConvertValue<int>(reader["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(row["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(row["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(row["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(row["UpdateSysUserSerialnum"]);
			this._DeviceSerialnum = DataUtils.ConvertValue<string>(row["DeviceSerialnum"]);
			this._Value = DataUtils.ConvertValue<decimal>(row["Value"]);
			this._Status = DataUtils.ConvertValue<int>(row["Status"]);
			this._Max = DataUtils.ConvertValue<decimal>(row["Max"]);
			this._Min = DataUtils.ConvertValue<decimal>(row["Min"]);
			this._Sort = DataUtils.ConvertValue<int>(row["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
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
			public readonly static Field All = new Field("*","DeviceDataExceptionLog");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","DeviceDataExceptionLog","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","DeviceDataExceptionLog","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","DeviceDataExceptionLog","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","DeviceDataExceptionLog","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","DeviceDataExceptionLog","更新用户");
			/// <summary>
			/// 设备编码
			/// </summary>
			public readonly static Field DeviceSerialnum = new Field("DeviceSerialnum","DeviceDataExceptionLog","设备编码");
			/// <summary>
			/// 设备值
			/// </summary>
			public readonly static Field Value = new Field("Value","DeviceDataExceptionLog","设备值");
			/// <summary>
			/// 异常类型（1：偏大，-1：偏小）
			/// </summary>
			public readonly static Field Status = new Field("Status","DeviceDataExceptionLog","异常类型（1：偏大，-1：偏小）");
			/// <summary>
			/// 上限
			/// </summary>
			public readonly static Field Max = new Field("Max","DeviceDataExceptionLog","上限");
			/// <summary>
			/// 下限
			/// </summary>
			public readonly static Field Min = new Field("Min","DeviceDataExceptionLog","下限");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","DeviceDataExceptionLog","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","DeviceDataExceptionLog","备注");
		}
		#endregion


	}
}

