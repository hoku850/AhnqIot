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
	/// 实体类AWProduct 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class AWProduct : Entity 
	{
		public AWProduct():base("AWProduct") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _Title;
		private string _Description;
		private string _SysDepartmentSerialnum;
		private string _AWProductTypeSerialnum;
		private string _PhotoUrl;
		private string _Href;
		private int _Hits;
		private string _Remark;
		private int? _Sort;
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
		/// 标题
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// 内容
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
		/// 机构编码
		/// </summary>
		public string SysDepartmentSerialnum
		{
			get{ return _SysDepartmentSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.SysDepartmentSerialnum,_SysDepartmentSerialnum,value);
				this._SysDepartmentSerialnum=value;
			}
		}
		/// <summary>
		/// 农气服务产品类型编码
		/// </summary>
		public string AWProductTypeSerialnum
		{
			get{ return _AWProductTypeSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.AWProductTypeSerialnum,_AWProductTypeSerialnum,value);
				this._AWProductTypeSerialnum=value;
			}
		}
		/// <summary>
		/// 图片
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
		/// 链接地址
		/// </summary>
		public string Href
		{
			get{ return _Href; }
			set
			{
				this.OnPropertyValueChange(_.Href,_Href,value);
				this._Href=value;
			}
		}
		/// <summary>
		/// 点击次数
		/// </summary>
		public int Hits
		{
			get{ return _Hits; }
			set
			{
				this.OnPropertyValueChange(_.Hits,_Hits,value);
				this._Hits=value;
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
		public int? Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
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
				_.Title,
				_.Description,
				_.SysDepartmentSerialnum,
				_.AWProductTypeSerialnum,
				_.PhotoUrl,
				_.Href,
				_.Hits,
				_.Remark,
				_.Sort};
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
				this._Title,
				this._Description,
				this._SysDepartmentSerialnum,
				this._AWProductTypeSerialnum,
				this._PhotoUrl,
				this._Href,
				this._Hits,
				this._Remark,
				this._Sort};
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
			this._Title = DataUtils.ConvertValue<string>(reader["Title"]);
			this._Description = DataUtils.ConvertValue<string>(reader["Description"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(reader["SysDepartmentSerialnum"]);
			this._AWProductTypeSerialnum = DataUtils.ConvertValue<string>(reader["AWProductTypeSerialnum"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(reader["PhotoUrl"]);
			this._Href = DataUtils.ConvertValue<string>(reader["Href"]);
			this._Hits = DataUtils.ConvertValue<int>(reader["Hits"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
			this._Sort = DataUtils.ConvertValue<int?>(reader["Sort"]);
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
			this._Title = DataUtils.ConvertValue<string>(row["Title"]);
			this._Description = DataUtils.ConvertValue<string>(row["Description"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(row["SysDepartmentSerialnum"]);
			this._AWProductTypeSerialnum = DataUtils.ConvertValue<string>(row["AWProductTypeSerialnum"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(row["PhotoUrl"]);
			this._Href = DataUtils.ConvertValue<string>(row["Href"]);
			this._Hits = DataUtils.ConvertValue<int>(row["Hits"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
			this._Sort = DataUtils.ConvertValue<int?>(row["Sort"]);
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
			public readonly static Field All = new Field("*","AWProduct");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","AWProduct","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","AWProduct","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","AWProduct","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","AWProduct","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","AWProduct","更新用户");
			/// <summary>
			/// 标题
			/// </summary>
			public readonly static Field Title = new Field("Title","AWProduct","标题");
			/// <summary>
			/// 内容
			/// </summary>
			public readonly static Field Description = new Field("Description","AWProduct","内容");
			/// <summary>
			/// 机构编码
			/// </summary>
			public readonly static Field SysDepartmentSerialnum = new Field("SysDepartmentSerialnum","AWProduct","机构编码");
			/// <summary>
			/// 农气服务产品类型编码
			/// </summary>
			public readonly static Field AWProductTypeSerialnum = new Field("AWProductTypeSerialnum","AWProduct","农气服务产品类型编码");
			/// <summary>
			/// 图片
			/// </summary>
			public readonly static Field PhotoUrl = new Field("PhotoUrl","AWProduct","图片");
			/// <summary>
			/// 链接地址
			/// </summary>
			public readonly static Field Href = new Field("Href","AWProduct","链接地址");
			/// <summary>
			/// 点击次数
			/// </summary>
			public readonly static Field Hits = new Field("Hits","AWProduct","点击次数");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","AWProduct","备注");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","AWProduct","排序");
		}
		#endregion


	}
}

