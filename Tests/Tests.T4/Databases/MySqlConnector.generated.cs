﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace MySqlConnectorDataContext
{
	public partial class TestmysqlconnectordbDB : LinqToDB.Data.DataConnection
	{
		public ITable<Alltype>           Alltypes           { get { return this.GetTable<Alltype>(); } }
		public ITable<Child>             Children           { get { return this.GetTable<Child>(); } }
		public ITable<Datatypetest>      Datatypetests      { get { return this.GetTable<Datatypetest>(); } }
		public ITable<Doctor>            Doctors            { get { return this.GetTable<Doctor>(); } }
		public ITable<Fulltextindextest> Fulltextindextests { get { return this.GetTable<Fulltextindextest>(); } }
		public ITable<Grandchild>        Grandchilds        { get { return this.GetTable<Grandchild>(); } }
		public ITable<Inheritancechild>  Inheritancechilds  { get { return this.GetTable<Inheritancechild>(); } }
		public ITable<Inheritanceparent> Inheritanceparents { get { return this.GetTable<Inheritanceparent>(); } }
		public ITable<Issue1993>         Issue1993          { get { return this.GetTable<Issue1993>(); } }
		public ITable<Linqdatatype>      Linqdatatypes      { get { return this.GetTable<Linqdatatype>(); } }
		public ITable<Parent>            Parents            { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients           { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People             { get { return this.GetTable<Person>(); } }
		/// <summary>
		/// VIEW
		/// </summary>
		public ITable<Personview>        Personviews        { get { return this.GetTable<Personview>(); } }
		public ITable<Testidentity>      Testidentities     { get { return this.GetTable<Testidentity>(); } }
		public ITable<Testmerge1>        Testmerge1         { get { return this.GetTable<Testmerge1>(); } }
		public ITable<Testmerge2>        Testmerge2         { get { return this.GetTable<Testmerge2>(); } }
		public ITable<Testsamename>      Testsamenames      { get { return this.GetTable<Testsamename>(); } }

		public TestmysqlconnectordbDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestmysqlconnectordbDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table("alltypes")]
	public partial class Alltype
	{
		[Column(),                      PrimaryKey, Identity] public int       ID                  { get; set; } // int(11)
		[Column("bigintDataType"),      Nullable            ] public long?     BigintDataType      { get; set; } // bigint(20)
		[Column("smallintDataType"),    Nullable            ] public short?    SmallintDataType    { get; set; } // smallint(6)
		[Column("tinyintDataType"),     Nullable            ] public sbyte?    TinyintDataType     { get; set; } // tinyint(4)
		[Column("mediumintDataType"),   Nullable            ] public int?      MediumintDataType   { get; set; } // mediumint(9)
		[Column("intDataType"),         Nullable            ] public int?      IntDataType         { get; set; } // int(11)
		[Column("numericDataType"),     Nullable            ] public decimal?  NumericDataType     { get; set; } // decimal(10,0)
		[Column("decimalDataType"),     Nullable            ] public decimal?  DecimalDataType     { get; set; } // decimal(10,0)
		[Column("doubleDataType"),      Nullable            ] public double?   DoubleDataType      { get; set; } // double
		[Column("floatDataType"),       Nullable            ] public float?    FloatDataType       { get; set; } // float
		[Column("dateDataType"),        Nullable            ] public DateTime? DateDataType        { get; set; } // date
		[Column("datetimeDataType"),    Nullable            ] public DateTime? DatetimeDataType    { get; set; } // datetime
		[Column("timestampDataType"),   Nullable            ] public DateTime? TimestampDataType   { get; set; } // timestamp
		[Column("timeDataType"),        Nullable            ] public TimeSpan? TimeDataType        { get; set; } // time
		[Column("yearDataType"),        Nullable            ] public int?      YearDataType        { get; set; } // year(4)
		[Column("year2DataType"),       Nullable            ] public int?      Year2DataType       { get; set; } // year(4)
		[Column("year4DataType"),       Nullable            ] public int?      Year4DataType       { get; set; } // year(4)
		[Column("charDataType"),        Nullable            ] public char?     CharDataType        { get; set; } // char(1)
		[Column("char20DataType"),      Nullable            ] public string?   Char20DataType      { get; set; } // char(20)
		[Column("varcharDataType"),     Nullable            ] public string?   VarcharDataType     { get; set; } // varchar(20)
		[Column("textDataType"),        Nullable            ] public string?   TextDataType        { get; set; } // text
		[Column("binaryDataType"),      Nullable            ] public byte[]?   BinaryDataType      { get; set; } // binary(3)
		[Column("varbinaryDataType"),   Nullable            ] public byte[]?   VarbinaryDataType   { get; set; } // varbinary(5)
		[Column("blobDataType"),        Nullable            ] public byte[]?   BlobDataType        { get; set; } // blob
		[Column("bitDataType"),         Nullable            ] public ulong?    BitDataType         { get; set; } // bit(3)
		[Column("enumDataType"),        Nullable            ] public string?   EnumDataType        { get; set; } // enum('Green','Red','Blue')
		[Column("setDataType"),         Nullable            ] public string?   SetDataType         { get; set; } // set('one','two')
		[Column("intUnsignedDataType"), Nullable            ] public uint?     IntUnsignedDataType { get; set; } // int(10) unsigned
		[Column("boolDataType"),        Nullable            ] public bool?     BoolDataType        { get; set; } // tinyint(1)
	}

	[Table("child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int(11)
		[Column, Nullable] public int? ChildID  { get; set; } // int(11)
	}

	[Table("datatypetest")]
	public partial class Datatypetest
	{
		[Column(),            PrimaryKey,  Identity] public int       DataTypeID { get; set; } // int(11)
		[Column("Binary_"),      Nullable          ] public byte[]?   Binary     { get; set; } // binary(50)
		[Column("Boolean_"),  NotNull              ] public ulong     Boolean    { get; set; } // bit(1)
		[Column("Byte_"),        Nullable          ] public sbyte?    Byte       { get; set; } // tinyint(4)
		[Column("Bytes_"),       Nullable          ] public byte[]?   Bytes      { get; set; } // varbinary(50)
		[Column("Char_"),        Nullable          ] public char?     Char       { get; set; } // char(1)
		[Column("DateTime_"),    Nullable          ] public DateTime? DateTime   { get; set; } // datetime
		[Column("Decimal_"),     Nullable          ] public decimal?  Decimal    { get; set; } // decimal(20,2)
		[Column("Double_"),      Nullable          ] public float?    Double     { get; set; } // float
		[Column("Guid_"),        Nullable          ] public byte[]?   Guid       { get; set; } // varbinary(50)
		[Column("Int16_"),       Nullable          ] public short?    Int16      { get; set; } // smallint(6)
		[Column("Int32_"),       Nullable          ] public int?      Int32      { get; set; } // int(11)
		[Column("Int64_"),       Nullable          ] public long?     Int64      { get; set; } // bigint(20)
		[Column("Money_"),       Nullable          ] public decimal?  Money      { get; set; } // decimal(20,4)
		[Column("SByte_"),       Nullable          ] public sbyte?    SByte      { get; set; } // tinyint(4)
		[Column("Single_"),      Nullable          ] public double?   Single     { get; set; } // double
		[Column("Stream_"),      Nullable          ] public byte[]?   Stream     { get; set; } // varbinary(50)
		[Column("String_"),      Nullable          ] public string?   String     { get; set; } // varchar(50)
		[Column("UInt16_"),      Nullable          ] public short?    UInt16     { get; set; } // smallint(6)
		[Column("UInt32_"),      Nullable          ] public int?      UInt32     { get; set; } // int(11)
		[Column("UInt64_"),      Nullable          ] public long?     UInt64     { get; set; } // bigint(20)
		[Column("Xml_"),         Nullable          ] public string?   Xml        { get; set; } // varchar(1000)
	}

	[Table("doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int(11)
		#nullable disable
		[Column,     NotNull] public string Taxonomy { get; set; } // varchar(50)
		#nullable enable

		#region Associations

		#nullable disable
		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Doctor_Person", BackReferenceName="DoctorPerson")]
		public Person Person { get; set; }

		#nullable enable

		#endregion
	}

	[Table("fulltextindextest")]
	public partial class Fulltextindextest
	{
		[Column("id"), PrimaryKey, Identity] public uint    Id         { get; set; } // int(10) unsigned
		[Column(),     Nullable            ] public string? TestField1 { get; set; } // text
		[Column(),     Nullable            ] public string? TestField2 { get; set; } // text
	}

	[Table("grandchild")]
	public partial class Grandchild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int(11)
		[Column, Nullable] public int? ChildID      { get; set; } // int(11)
		[Column, Nullable] public int? GrandChildID { get; set; } // int(11)
	}

	[Table("inheritancechild")]
	public partial class Inheritancechild
	{
		[PrimaryKey, NotNull    ] public int     InheritanceChildId  { get; set; } // int(11)
		[Column,     NotNull    ] public int     InheritanceParentId { get; set; } // int(11)
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int(11)
		[Column,        Nullable] public string? Name                { get; set; } // varchar(50)
	}

	[Table("inheritanceparent")]
	public partial class Inheritanceparent
	{
		[PrimaryKey, NotNull    ] public int     InheritanceParentId { get; set; } // int(11)
		[Column,        Nullable] public int?    TypeDiscriminator   { get; set; } // int(11)
		[Column,        Nullable] public string? Name                { get; set; } // varchar(50)
	}

	[Table("issue1993")]
	public partial class Issue1993
	{
		[Column("id"),          PrimaryKey, Identity] public uint    Id          { get; set; } // int(10) unsigned
		[Column("description"), Nullable            ] public string? Description { get; set; } // varchar(100)
	}

	[Table("linqdatatypes")]
	public partial class Linqdatatype
	{
		[Column, Nullable] public int?      ID             { get; set; } // int(11)
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // decimal(10,4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // datetime(3)
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column, Nullable] public bool?     BoolValue      { get; set; } // tinyint(1)
		[Column, Nullable] public string?   GuidValue      { get; set; } // char(36)
		[Column, Nullable] public byte[]?   BinaryValue    { get; set; } // varbinary(5000)
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // smallint(6)
		[Column, Nullable] public int?      IntValue       { get; set; } // int(11)
		[Column, Nullable] public long?     BigIntValue    { get; set; } // bigint(20)
		[Column, Nullable] public string?   StringValue    { get; set; } // varchar(50)
	}

	[Table("parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int(11)
		[Column, Nullable] public int? Value1   { get; set; } // int(11)
	}

	[Table("patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int(11)
		#nullable disable
		[Column,     NotNull] public string Diagnosis { get; set; } // varchar(256)
		#nullable enable

		#region Associations

		#nullable disable
		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Patient_Person", BackReferenceName="PatientPerson")]
		public Person Person { get; set; }

		#nullable enable

		#endregion
	}

	[Table("person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int     PersonID   { get; set; } // int(11)
		#nullable disable
		[Column,     NotNull    ] public string  FirstName  { get; set; } // varchar(50)
		#nullable enable
		#nullable disable
		[Column,     NotNull    ] public string  LastName   { get; set; } // varchar(50)
		#nullable enable
		[Column,        Nullable] public string? MiddleName { get; set; } // varchar(50)
		[Column,     NotNull    ] public char    Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Doctor? DoctorPerson { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Patient? PatientPerson { get; set; }

		#endregion
	}

	/// <summary>
	/// VIEW
	/// </summary>
	[Table("personview", IsView=true)]
	public partial class Personview
	{
		[Column, NotNull] public int ID { get; set; } // int(11)
	}

	[Table("testidentity")]
	public partial class Testidentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // int(11)
	}

	[Table("testmerge1")]
	public partial class Testmerge1
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int(11)
		[Column,        Nullable] public int?      Field1          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field2          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field3          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field4          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field5          { get; set; } // int(11)
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint(20)
		[Column,        Nullable] public ulong?    FieldBoolean    { get; set; } // bit(1)
		[Column,        Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // varchar(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // char(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // float
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // double
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string?   FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24,10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // time
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int(11)
	}

	[Table("testmerge2")]
	public partial class Testmerge2
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int(11)
		[Column,        Nullable] public int?      Field1          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field2          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field3          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field4          { get; set; } // int(11)
		[Column,        Nullable] public int?      Field5          { get; set; } // int(11)
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint(20)
		[Column,        Nullable] public ulong?    FieldBoolean    { get; set; } // bit(1)
		[Column,        Nullable] public string?   FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string?   FieldNString    { get; set; } // varchar(20)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public char?     FieldNChar      { get; set; } // char(1)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // float
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // double
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public byte[]?   FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string?   FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24,10)
		[Column,        Nullable] public DateTime? FieldDate       { get; set; } // date
		[Column,        Nullable] public TimeSpan? FieldTime       { get; set; } // time
		[Column,        Nullable] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int(11)
	}

	[Table("testsamename")]
	public partial class Testsamename
	{
		[PrimaryKey, NotNull] public int ID { get; set; } // int(11)
	}

	public static partial class TestmysqlconnectordbDBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this TestmysqlconnectordbDB dataConnection)
		{
			return dataConnection.ExecuteProc("`AddIssue792Record`");
		}

		#endregion

		#region TestOutputParametersWithoutTableProcedure

		public static int TestOutputParametersWithoutTableProcedure(this TestmysqlconnectordbDB dataConnection, string? aInParam, out sbyte? aOutParam)
		{
			var ret = dataConnection.ExecuteProc("`TestOutputParametersWithoutTableProcedure`",
				new DataParameter("aInParam",  aInParam,  DataType.VarChar),
				new DataParameter("aOutParam", null, DataType.SByte) { Direction = ParameterDirection.Output });

			aOutParam = Converter.ChangeTypeTo<sbyte?>(((IDbDataParameter)dataConnection.Command.Parameters["aOutParam"]).Value);

			return ret;
		}

		#endregion

		#region TestProcedure

		public static IEnumerable<Person> TestProcedure(this TestmysqlconnectordbDB dataConnection, int? param3, ref int? param2, out int? param1)
		{
			var ret = dataConnection.QueryProc<Person>("`TestProcedure`",
				new DataParameter("param3", param3, DataType.Int32),
				new DataParameter("param2", param2, DataType.Int32) { Direction = ParameterDirection.InputOutput },
				new DataParameter("param1", null, DataType.Int32) { Direction = ParameterDirection.Output }).ToList();

			param2 = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["param2"]).Value);
			param1 = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["param1"]).Value);

			return ret;
		}

		#endregion
	}

	public static partial class SqlFunctions
	{
		#region TestFunction

		[Sql.Function(Name="TestFunction", ServerSideOnly=true)]
		public static string? TestFunction(int? param)
		{
			throw new InvalidOperationException();
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Alltype Find(this ITable<Alltype> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Datatypetest Find(this ITable<Datatypetest> table, int DataTypeID)
		{
			return table.FirstOrDefault(t =>
				t.DataTypeID == DataTypeID);
		}

		public static Doctor Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Fulltextindextest Find(this ITable<Fulltextindextest> table, uint Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Inheritancechild Find(this ITable<Inheritancechild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static Inheritanceparent Find(this ITable<Inheritanceparent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Issue1993 Find(this ITable<Issue1993> table, uint Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Patient Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Testidentity Find(this ITable<Testidentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Testmerge1 Find(this ITable<Testmerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Testmerge2 Find(this ITable<Testmerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Testsamename Find(this ITable<Testsamename> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}

#nullable restore
#pragma warning restore 1591
