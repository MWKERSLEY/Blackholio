// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

using System;
using System.Collections.Generic;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	[Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
	public partial class Circle : IDatabaseTable
	{
		[Newtonsoft.Json.JsonProperty("circle_id")]
		public SpacetimeDB.Identity CircleId;
		[Newtonsoft.Json.JsonProperty("entity_id")]
		public uint EntityId;
		[Newtonsoft.Json.JsonProperty("name")]
		public string Name;
		[Newtonsoft.Json.JsonProperty("direction")]
		public SpacetimeDB.Types.Vector2 Direction;
		[Newtonsoft.Json.JsonProperty("magnitude")]
		public float Magnitude;

		private static Dictionary<SpacetimeDB.Identity, Circle> CircleId_Index = new Dictionary<SpacetimeDB.Identity, Circle>(16);
		private static Dictionary<uint, Circle> EntityId_Index = new Dictionary<uint, Circle>(16);
		private static Dictionary<string, Circle> Name_Index = new Dictionary<string, Circle>(16);

		private static void InternalOnValueInserted(object insertedValue)
		{
			var val = (Circle)insertedValue;
			CircleId_Index[val.CircleId] = val;
			EntityId_Index[val.EntityId] = val;
			Name_Index[val.Name] = val;
		}

		private static void InternalOnValueDeleted(object deletedValue)
		{
			var val = (Circle)deletedValue;
			CircleId_Index.Remove(val.CircleId);
			EntityId_Index.Remove(val.EntityId);
			Name_Index.Remove(val.Name);
		}

		public static SpacetimeDB.SATS.AlgebraicType GetAlgebraicType()
		{
			return SpacetimeDB.SATS.AlgebraicType.CreateProductType(new SpacetimeDB.SATS.ProductTypeElement[]
			{
				new SpacetimeDB.SATS.ProductTypeElement("circle_id", SpacetimeDB.SATS.AlgebraicType.CreateProductType(new SpacetimeDB.SATS.ProductTypeElement[]
			{
				new SpacetimeDB.SATS.ProductTypeElement("__identity_bytes", SpacetimeDB.SATS.AlgebraicType.CreateArrayType(SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.U8))),
			})),
				new SpacetimeDB.SATS.ProductTypeElement("entity_id", SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.U32)),
				new SpacetimeDB.SATS.ProductTypeElement("name", SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.String)),
				new SpacetimeDB.SATS.ProductTypeElement("direction", SpacetimeDB.Types.Vector2.GetAlgebraicType()),
				new SpacetimeDB.SATS.ProductTypeElement("magnitude", SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.F32)),
			});
		}

		public static explicit operator Circle(SpacetimeDB.SATS.AlgebraicValue value)
		{
			if (value == null) {
				return null;
			}
			var productValue = value.AsProductValue();
			return new Circle
			{
				CircleId = SpacetimeDB.Identity.From(productValue.elements[0].AsProductValue().elements[0].AsBytes()),
				EntityId = productValue.elements[1].AsU32(),
				Name = productValue.elements[2].AsString(),
				Direction = (SpacetimeDB.Types.Vector2)(productValue.elements[3]),
				Magnitude = productValue.elements[4].AsF32(),
			};
		}

		public static System.Collections.Generic.IEnumerable<Circle> Iter()
		{
			foreach(var entry in SpacetimeDBClient.clientDB.GetEntries("Circle"))
			{
				yield return (Circle)entry.Item2;
			}
		}
		public static int Count()
		{
			return SpacetimeDBClient.clientDB.Count("Circle");
		}
		public static Circle FilterByCircleId(SpacetimeDB.Identity value)
		{
			CircleId_Index.TryGetValue(value, out var r);
			return r;
		}

		public static Circle FilterByEntityId(uint value)
		{
			EntityId_Index.TryGetValue(value, out var r);
			return r;
		}

		public static Circle FilterByName(string value)
		{
			Name_Index.TryGetValue(value, out var r);
			return r;
		}

		public static System.Collections.Generic.IEnumerable<Circle> FilterByMagnitude(float value)
		{
			foreach(var entry in SpacetimeDBClient.clientDB.GetEntries("Circle"))
			{
				var productValue = entry.Item1.AsProductValue();
				var compareValue = (float)productValue.elements[4].AsF32();
				if (compareValue == value) {
					yield return (Circle)entry.Item2;
				}
			}
		}

		public static bool ComparePrimaryKey(SpacetimeDB.SATS.AlgebraicType t, SpacetimeDB.SATS.AlgebraicValue v1, SpacetimeDB.SATS.AlgebraicValue v2)
		{
			var primaryColumnValue1 = v1.AsProductValue().elements[0];
			var primaryColumnValue2 = v2.AsProductValue().elements[0];
			return SpacetimeDB.SATS.AlgebraicValue.Compare(t.product.elements[0].algebraicType, primaryColumnValue1, primaryColumnValue2);
		}

		public static SpacetimeDB.SATS.AlgebraicValue GetPrimaryKeyValue(SpacetimeDB.SATS.AlgebraicValue v)
		{
			return v.AsProductValue().elements[0];
		}

		public static SpacetimeDB.SATS.AlgebraicType GetPrimaryKeyType(SpacetimeDB.SATS.AlgebraicType t)
		{
			return t.product.elements[0].algebraicType;
		}

		public delegate void InsertEventHandler(Circle insertedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void UpdateEventHandler(Circle oldValue, Circle newValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void DeleteEventHandler(Circle deletedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void RowUpdateEventHandler(SpacetimeDBClient.TableOp op, Circle oldValue, Circle newValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public static event InsertEventHandler OnInsert;
		public static event UpdateEventHandler OnUpdate;
		public static event DeleteEventHandler OnBeforeDelete;
		public static event DeleteEventHandler OnDelete;
		public static event RowUpdateEventHandler OnRowUpdate;

		public static void OnInsertEvent(object newValue, ClientApi.Event dbEvent)
		{
			OnInsert?.Invoke((Circle)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnUpdateEvent(object oldValue, object newValue, ClientApi.Event dbEvent)
		{
			OnUpdate?.Invoke((Circle)oldValue,(Circle)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnBeforeDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnBeforeDelete?.Invoke((Circle)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnDelete?.Invoke((Circle)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnRowUpdateEvent(SpacetimeDBClient.TableOp op, object oldValue, object newValue, ClientApi.Event dbEvent)
		{
			OnRowUpdate?.Invoke(op, (Circle)oldValue,(Circle)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}
	}
}
