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
	/// 实体类FacilityType 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class FacilityType : Entity 
	{
		public FacilityType():base("FacilityType") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _Name;
		private string _ParentSerialnum;
		private bool _IsSystem;
		private string _Css;
		private string _PhotoUrl;
		private string _Introduce;
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
		/// 名称
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 上级
		/// </summary>
		public string ParentSerialnum
		{
			get{ return _ParentSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.ParentSerialnum,_ParentSerialnum,value);
				this._ParentSerialnum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsSystem
		{
			get{ return _IsSystem; }
			set
			{
				this.OnPropertyValueChange(_.IsSystem,_IsSystem,value);
				this._IsSystem=value;
			}
		}
		/// <summary>
		/// css
		/// </summary>
		public string Css
		{
			get{ return _Css; }
			set
			{
				this.OnPropertyValueChange(_.Css,_Css,value);
				this._Css=value;
			}
		}
		/// <summary>
		/// 形象图片
		/// </summary>
		public string PhotoUrl
		{
			get{ return _PhotoUrl; }
			set
			{
				this.OnPropertyValueChange(_.PhotoUrl,_PhotoUrl,value);
				this._PhotoUrl=value;
			}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Introduce
		{
			get{ return _Introduce; }
			set
			{
				this.OnPropertyValueChange(_.Introduce,_Introduce,value);
				this._Introduce=value;
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
				_.Name,
				_.ParentSerialnum,
				_.IsSystem,
				_.Css,
				_.PhotoUrl,
				_.Introduce,
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
				this._Name,
				this._ParentSerialnum,
				this._IsSystem,
				this._Css,
				this._PhotoUrl,
				this._Introduce,
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
			this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
			this._ParentSerialnum = DataUtils.ConvertValue<string>(reader["ParentSerialnum"]);
			this._IsSystem = DataUtils.ConvertValue<bool>(reader["IsSystem"]);
			this._Css = DataUtils.ConvertValue<string>(reader["Css"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(reader["PhotoUrl"]);
			this._Introduce = DataUtils.ConvertValue<string>(reader["Introduce"]);
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
			this._Name = DataUtils.ConvertValue<string>(row["Name"]);
			this._ParentSerialnum = DataUtils.ConvertValue<string>(row["ParentSerialnum"]);
			this._IsSystem = DataUtils.ConvertValue<bool>(row["IsSystem"]);
			this._Css = DataUtils.ConvertValue<string>(row["Css"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(row["PhotoUrl"]);
			this._Introduce = DataUtils.ConvertValue<string>(row["Introduce"]);
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
			public readonly static Field All = new Field("*","FacilityType");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","FacilityType","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","FacilityType","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","FacilityType","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","FacilityType","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","FacilityType","更新用户");
			/// <summary>
			/// 名称
			/// </summary>
			public readonly static Field Name = new Field("Name","FacilityType","名称");
			/// <summary>
			/// 上级
			/// </summary>
			public readonly static Field ParentSerialnum = new Field("ParentSerialnum","FacilityType","上级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsSystem = new Field("IsSystem","FacilityType","IsSystem");
			/// <summary>
			/// css
			/// </summary>
			public readonly static Field Css = new Field("Css","FacilityType","css");
			/// <summary>
			/// 形象图片
			/// </summary>
			public readonly static Field PhotoUrl = new Field("PhotoUrl","FacilityType","形象图片");
			/// <summary>
			/// 描述
			/// </summary>
			public readonly static Field Introduce = new Field("Introduce","FacilityType","描述");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","FacilityType","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","FacilityType","备注");
		}
		#endregion


	}
}

