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
	/// 实体类NewClassByContent 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class NewClassByContent : Entity 
	{
		public NewClassByContent():base("NewClassByContent") {}

		#region Model
		private int _ID;
		private Guid? _ContentGUID;
		private Guid? _NewsClass;
		private string _Title;
		private string _Title1;
		private int? _Click;
		private DateTime? _DateTime;
		private int? _BeNew;
		private int? _Enable;
		private int? _Serial;
		private int? _BeOnly;
		private int? _AnswerNum;
		/// <summary>
		/// 
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
		/// 内容编码
		/// </summary>
		public Guid? ContentGUID
		{
			get{ return _ContentGUID; }
			set
			{
				this.OnPropertyValueChange(_.ContentGUID,_ContentGUID,value);
				this._ContentGUID=value;
			}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public Guid? NewsClass
		{
			get{ return _NewsClass; }
			set
			{
				this.OnPropertyValueChange(_.NewsClass,_NewsClass,value);
				this._NewsClass=value;
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
		/// 标题1
		/// </summary>
		public string Title1
		{
			get{ return _Title1; }
			set
			{
				this.OnPropertyValueChange(_.Title1,_Title1,value);
				this._Title1=value;
			}
		}
		/// <summary>
		/// 点击数
		/// </summary>
		public int? Click
		{
			get{ return _Click; }
			set
			{
				this.OnPropertyValueChange(_.Click,_Click,value);
				this._Click=value;
			}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? DateTime
		{
			get{ return _DateTime; }
			set
			{
				this.OnPropertyValueChange(_.DateTime,_DateTime,value);
				this._DateTime=value;
			}
		}
		/// <summary>
		/// F1:new;2:import
		/// </summary>
		public int? BeNew
		{
			get{ return _BeNew; }
			set
			{
				this.OnPropertyValueChange(_.BeNew,_BeNew,value);
				this._BeNew=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Enable
		{
			get{ return _Enable; }
			set
			{
				this.OnPropertyValueChange(_.Enable,_Enable,value);
				this._Enable=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Serial
		{
			get{ return _Serial; }
			set
			{
				this.OnPropertyValueChange(_.Serial,_Serial,value);
				this._Serial=value;
			}
		}
		/// <summary>
		/// F0:ahnw;1:ahsp;2:two
		/// </summary>
		public int? BeOnly
		{
			get{ return _BeOnly; }
			set
			{
				this.OnPropertyValueChange(_.BeOnly,_BeOnly,value);
				this._BeOnly=value;
			}
		}
		/// <summary>
		/// 回复数
		/// </summary>
		public int? AnswerNum
		{
			get{ return _AnswerNum; }
			set
			{
				this.OnPropertyValueChange(_.AnswerNum,_AnswerNum,value);
				this._AnswerNum=value;
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
				_.ContentGUID,
				_.NewsClass,
				_.Title,
				_.Title1,
				_.Click,
				_.DateTime,
				_.BeNew,
				_.Enable,
				_.Serial,
				_.BeOnly,
				_.AnswerNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._ContentGUID,
				this._NewsClass,
				this._Title,
				this._Title1,
				this._Click,
				this._DateTime,
				this._BeNew,
				this._Enable,
				this._Serial,
				this._BeOnly,
				this._AnswerNum};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._ID = DataUtils.ConvertValue<int>(reader["ID"]);
			this._ContentGUID = DataUtils.ConvertValue<Guid?>(reader["ContentGUID"]);
			this._NewsClass = DataUtils.ConvertValue<Guid?>(reader["NewsClass"]);
			this._Title = DataUtils.ConvertValue<string>(reader["Title"]);
			this._Title1 = DataUtils.ConvertValue<string>(reader["Title1"]);
			this._Click = DataUtils.ConvertValue<int?>(reader["Click"]);
			this._DateTime = DataUtils.ConvertValue<DateTime?>(reader["DateTime"]);
			this._BeNew = DataUtils.ConvertValue<int?>(reader["BeNew"]);
			this._Enable = DataUtils.ConvertValue<int?>(reader["Enable"]);
			this._Serial = DataUtils.ConvertValue<int?>(reader["Serial"]);
			this._BeOnly = DataUtils.ConvertValue<int?>(reader["BeOnly"]);
			this._AnswerNum = DataUtils.ConvertValue<int?>(reader["AnswerNum"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._ID = DataUtils.ConvertValue<int>(row["ID"]);
			this._ContentGUID = DataUtils.ConvertValue<Guid?>(row["ContentGUID"]);
			this._NewsClass = DataUtils.ConvertValue<Guid?>(row["NewsClass"]);
			this._Title = DataUtils.ConvertValue<string>(row["Title"]);
			this._Title1 = DataUtils.ConvertValue<string>(row["Title1"]);
			this._Click = DataUtils.ConvertValue<int?>(row["Click"]);
			this._DateTime = DataUtils.ConvertValue<DateTime?>(row["DateTime"]);
			this._BeNew = DataUtils.ConvertValue<int?>(row["BeNew"]);
			this._Enable = DataUtils.ConvertValue<int?>(row["Enable"]);
			this._Serial = DataUtils.ConvertValue<int?>(row["Serial"]);
			this._BeOnly = DataUtils.ConvertValue<int?>(row["BeOnly"]);
			this._AnswerNum = DataUtils.ConvertValue<int?>(row["AnswerNum"]);
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
			public readonly static Field All = new Field("*","NewClassByContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","NewClassByContent","ID");
			/// <summary>
			/// 内容编码
			/// </summary>
			public readonly static Field ContentGUID = new Field("ContentGUID","NewClassByContent","内容编码");
			/// <summary>
			/// 类型
			/// </summary>
			public readonly static Field NewsClass = new Field("NewsClass","NewClassByContent","类型");
			/// <summary>
			/// 标题
			/// </summary>
			public readonly static Field Title = new Field("Title","NewClassByContent","标题");
			/// <summary>
			/// 标题1
			/// </summary>
			public readonly static Field Title1 = new Field("Title1","NewClassByContent","标题1");
			/// <summary>
			/// 点击数
			/// </summary>
			public readonly static Field Click = new Field("Click","NewClassByContent","点击数");
			/// <summary>
			/// 时间
			/// </summary>
			public readonly static Field DateTime = new Field("DateTime","NewClassByContent","时间");
			/// <summary>
			/// F1:new;2:import
			/// </summary>
			public readonly static Field BeNew = new Field("BeNew","NewClassByContent","F1:new;2:import");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Enable = new Field("Enable","NewClassByContent","Enable");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Serial = new Field("Serial","NewClassByContent","Serial");
			/// <summary>
			/// F0:ahnw;1:ahsp;2:two
			/// </summary>
			public readonly static Field BeOnly = new Field("BeOnly","NewClassByContent","F0:ahnw;1:ahsp;2:two");
			/// <summary>
			/// 回复数
			/// </summary>
			public readonly static Field AnswerNum = new Field("AnswerNum","NewClassByContent","回复数");
		}
		#endregion


	}
}

