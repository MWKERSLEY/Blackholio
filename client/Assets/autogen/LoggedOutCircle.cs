// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

using System;
using System.Collections.Generic;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	[Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
	public partial class LoggedOutCircle : IDatabaseTable
	{
		[Newtonsoft.Json.JsonProperty("circle_id")]
		public SpacetimeDB.Identity CircleId;
		[Newtonsoft.Json.JsonProperty("circle")]
		public SpacetimeDB.Types.Circle Circle;
		[Newtonsoft.Json.JsonProperty("entity")]
		public SpacetimeDB.Types.Entity Entity;

		private static Dictionary<SpacetimeDB.Identity, LoggedOutCircle> CircleId_Index = new Dictionary<SpacetimeDB.Identity, LoggedOutCircle>(16);

		private static void InternalOnValueInserted(object insertedValue)
		{
			var val = (LoggedOutCircle)insertedValue;
			CircleId_Index[val.CircleId] = val;
		}

		private static void InternalOnValueDeleted(object deletedValue)
		{
			var val = (LoggedOutCircle)deletedValue;
			CircleId_Index.Remove(val.CircleId);
		}

		public static SpacetimeDB.SATS.AlgebraicType GetAlgebraicType()
		{
			return SpacetimeDB.SATS.AlgebraicType.CreateProductType(new SpacetimeDB.SATS.ProductTypeElement[]
			{
				new SpacetimeDB.SATS.ProductTypeElement("circle_id", SpacetimeDB.SATS.AlgebraicType.CreateProductType(new SpacetimeDB.SATS.ProductTypeElement[]
			{
				new SpacetimeDB.SATS.ProductTypeElement("__identity_bytes", SpacetimeDB.SATS.AlgebraicType.CreateArrayType(SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.U8))),
			})),
				new SpacetimeDB.SATS.ProductTypeElement("circle", SpacetimeDB.Types.Circle.GetAlgebraicType()),
				new SpacetimeDB.SATS.ProductTypeElement("entity", SpacetimeDB.Types.Entity.GetAlgebraicType()),
			});
		}

		public static explicit operator LoggedOutCircle(SpacetimeDB.SATS.AlgebraicValue value)
		{
			if (value == null) {
				return null;
			}
			var productValue = value.AsProductValue();
			return new LoggedOutCircle
			{
				CircleId = SpacetimeDB.Identity.From(productValue.elements[0].AsProductValue().elements[0].AsBytes()),
				Circle = (SpacetimeDB.Types.Circle)(productValue.elements[1]),
				Entity = (SpacetimeDB.Types.Entity)(productValue.elements[2]),
			};
		}

		public static System.Collections.Generic.IEnumerable<LoggedOutCircle> Iter()
		{
			foreach(var entry in SpacetimeDBClient.clientDB.GetEntries("LoggedOutCircle"))
			{
				yield return (LoggedOutCircle)entry.Item2;
			}
		}
		public static int Count()
		{
			return SpacetimeDBClient.clientDB.Count("LoggedOutCircle");
		}
		public static LoggedOutCircle FilterByCircleId(SpacetimeDB.Identity value)
		{
			CircleId_Index.TryGetValue(value, out var r);
			return r;
		}

		public static bool ComparePrimaryKey(SpacetimeDB.SATS.AlgebraicType t, SpacetimeDB.SATS.AlgebraicValue _v1, SpacetimeDB.SATS.AlgebraicValue _v2)
		{
			return false;
		}

		public delegate void InsertEventHandler(LoggedOutCircle insertedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void DeleteEventHandler(LoggedOutCircle deletedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void RowUpdateEventHandler(SpacetimeDBClient.TableOp op, LoggedOutCircle oldValue, LoggedOutCircle newValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public static event InsertEventHandler OnInsert;
		public static event DeleteEventHandler OnBeforeDelete;
		public static event DeleteEventHandler OnDelete;
		public static event RowUpdateEventHandler OnRowUpdate;

		public static void OnInsertEvent(object newValue, ClientApi.Event dbEvent)
		{
			OnInsert?.Invoke((LoggedOutCircle)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnBeforeDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnBeforeDelete?.Invoke((LoggedOutCircle)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnDelete?.Invoke((LoggedOutCircle)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnRowUpdateEvent(SpacetimeDBClient.TableOp op, object oldValue, object newValue, ClientApi.Event dbEvent)
		{
			OnRowUpdate?.Invoke(op, (LoggedOutCircle)oldValue,(LoggedOutCircle)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}
	}
}
