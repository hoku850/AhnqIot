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
	/// 实体类Log 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Log : Entity 
	{
		public Log():base("Log") {}

		#region Model
		private int _ID;
		private string _Category;
		private string _Action;
		private int? _UserID;
		private string _UserName;
		private string _IP;
		private DateTime _OccurTime;
		private string _Remark;
		/// <summary>
		/// 编号
		/// </summary>
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// 类别
		/// </summary>
		public string Category
		{
			get{ return _Category; }
			set
			{
				this.OnPropertyValueChange(_.Category,_Category,value);
				this._Category=value;
			}
		}
		/// <summary>
		/// 操作
		/// </summary>
		public string Action
		{
			get{ return _Action; }
			set
			{
				this.OnPropertyValueChange(_.Action,_Action,value);
				this._Action=value;
			}
		}
		/// <summary>
		/// 用户编号
		/// </summary>
		public int? UserID
		{
			get{ return _UserID; }
			set
			{
				this.OnPropertyValueChange(_.UserID,_UserID,value);
				this._UserID=value;
			}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			get{ return _UserName; }
			set
			{
				this.OnPropertyValueChange(_.UserName,_UserName,value);
				this._UserName=value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string IP
		{
			get{ return _IP; }
			set
			{
				this.OnPropertyValueChange(_.IP,_IP,value);
				this._IP=value;
			}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime OccurTime
		{
			get{ return _OccurTime; }
			set
			{
				this.OnPropertyValueChange(_.OccurTime,_OccurTime,value);
				this._OccurTime=value;
			}
		}
		/// <summary>
		/// 详细信息
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
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.Category,
				_.Action,
				_.UserID,
				_.UserName,
				_.IP,
				_.OccurTime,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._Category,
				this._Action,
				this._UserID,
				this._UserName,
				this._IP,
				this._OccurTime,
				this._Remark};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._ID = DataUtils.ConvertValue<int>(reader["ID"]);
			this._Category = DataUtils.ConvertValue<string>(reader["Category"]);
			this._Action = DataUtils.ConvertValue<string>(reader["Action"]);
			this._UserID = DataUtils.ConvertValue<int?>(reader["UserID"]);
			this._UserName = DataUtils.ConvertValue<string>(reader["UserName"]);
			this._IP = DataUtils.ConvertValue<string>(reader["IP"]);
			this._OccurTime = DataUtils.ConvertValue<DateTime>(reader["OccurTime"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._ID = DataUtils.ConvertValue<int>(row["ID"]);
			this._Category = DataUtils.ConvertValue<string>(row["Category"]);
			this._Action = DataUtils.ConvertValue<string>(row["Action"]);
			this._UserID = DataUtils.ConvertValue<int?>(row["UserID"]);
			this._UserName = DataUtils.ConvertValue<string>(row["UserName"]);
			this._IP = DataUtils.ConvertValue<string>(row["IP"]);
			this._OccurTime = DataUtils.ConvertValue<DateTime>(row["OccurTime"]);
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
			public readonly static Field All = new Field("*","Log");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field ID = new Field("ID","Log","编号");
			/// <summary>
			/// 类别
			/// </summary>
			public readonly static Field Category = new Field("Category","Log","类别");
			/// <summary>
			/// 操作
			/// </summary>
			public readonly static Field Action = new Field("Action","Log","操作");
			/// <summary>
			/// 用户编号
			/// </summary>
			public readonly static Field UserID = new Field("UserID","Log","用户编号");
			/// <summary>
			/// 用户名
			/// </summary>
			public readonly static Field UserName = new Field("UserName","Log","用户名");
			/// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field IP = new Field("IP","Log","IP地址");
			/// <summary>
			/// 时间
			/// </summary>
			public readonly static Field OccurTime = new Field("OccurTime","Log","时间");
			/// <summary>
			/// 详细信息
			/// </summary>
			public readonly static Field Remark = new Field("Remark","Log","详细信息");
		}
		#endregion


	}
}

