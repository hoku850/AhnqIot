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
	/// 实体类SysRole 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SysRole : Entity 
	{
		public SysRole():base("SysRole") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _Name;
		private string _Url;
		private bool _IsSystem;
		private string _Description;
		private int _Status;
		private string _Permission;
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
		/// 角色名称
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
		/// 访问地址
		/// </summary>
		public string Url
		{
			get{ return _Url; }
			set
			{
				this.OnPropertyValueChange(_.Url,_Url,value);
				this._Url=value;
			}
		}
		/// <summary>
		/// 是否系统角色。系统角色用于业务系统开发使用，禁止修改名称或删除
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
		/// 描述
		/// </summary>
		public string Description
		{
			get{ return _Description; }
			set
			{
				this.OnPropertyValueChange(_.Description,_Description,value);
				this._Description=value;
			}
		}
		/// <summary>
		/// 状态。状态（1：启用，0：禁用，2...）
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
		/// 权限。对不同资源的权限，逗号分隔，每个资源的权限子项竖线分隔
		/// </summary>
		public string Permission
		{
			get{ return _Permission; }
			set
			{
				this.OnPropertyValueChange(_.Permission,_Permission,value);
				this._Permission=value;
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
				_.Url,
				_.IsSystem,
				_.Description,
				_.Status,
				_.Permission,
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
				this._Url,
				this._IsSystem,
				this._Description,
				this._Status,
				this._Permission,
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
			this._Url = DataUtils.ConvertValue<string>(reader["Url"]);
			this._IsSystem = DataUtils.ConvertValue<bool>(reader["IsSystem"]);
			this._Description = DataUtils.ConvertValue<string>(reader["Description"]);
			this._Status = DataUtils.ConvertValue<int>(reader["Status"]);
			this._Permission = DataUtils.ConvertValue<string>(reader["Permission"]);
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
			this._Url = DataUtils.ConvertValue<string>(row["Url"]);
			this._IsSystem = DataUtils.ConvertValue<bool>(row["IsSystem"]);
			this._Description = DataUtils.ConvertValue<string>(row["Description"]);
			this._Status = DataUtils.ConvertValue<int>(row["Status"]);
			this._Permission = DataUtils.ConvertValue<string>(row["Permission"]);
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
			public readonly static Field All = new Field("*","SysRole");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","SysRole","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","SysRole","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","SysRole","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","SysRole","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","SysRole","更新用户");
			/// <summary>
			/// 角色名称
			/// </summary>
			public readonly static Field Name = new Field("Name","SysRole","角色名称");
			/// <summary>
			/// 访问地址
			/// </summary>
			public readonly static Field Url = new Field("Url","SysRole","访问地址");
			/// <summary>
			/// 是否系统角色。系统角色用于业务系统开发使用，禁止修改名称或删除
			/// </summary>
			public readonly static Field IsSystem = new Field("IsSystem","SysRole","是否系统角色。系统角色用于业务系统开发使用，禁止修改名称或删除");
			/// <summary>
			/// 描述
			/// </summary>
			public readonly static Field Description = new Field("Description","SysRole","描述");
			/// <summary>
			/// 状态。状态（1：启用，0：禁用，2...）
			/// </summary>
			public readonly static Field Status = new Field("Status","SysRole","状态。状态（1：启用，0：禁用，2...）");
			/// <summary>
			/// 权限。对不同资源的权限，逗号分隔，每个资源的权限子项竖线分隔
			/// </summary>
			public readonly static Field Permission = new Field("Permission","SysRole","权限。对不同资源的权限，逗号分隔，每个资源的权限子项竖线分隔");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","SysRole","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","SysRole","备注");
		}
		#endregion


	}
}

