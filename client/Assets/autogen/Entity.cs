// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

using System;
using System.Collections.Generic;
using SpacetimeDB;

namespace SpacetimeDB.Types
{
	[Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
	public partial class Entity : IDatabaseTable
	{
		[Newtonsoft.Json.JsonProperty("id")]
		public uint Id;
		[Newtonsoft.Json.JsonProperty("position")]
		public SpacetimeDB.Types.Vector2 Position;
		[Newtonsoft.Json.JsonProperty("mass")]
		public uint Mass;

		private static Dictionary<uint, Entity> Id_Index = new Dictionary<uint, Entity>(16);

		private static void InternalOnValueInserted(object insertedValue)
		{
			var val = (Entity)insertedValue;
			Id_Index[val.Id] = val;
		}

		private static void InternalOnValueDeleted(object deletedValue)
		{
			var val = (Entity)deletedValue;
			Id_Index.Remove(val.Id);
		}

		public static SpacetimeDB.SATS.AlgebraicType GetAlgebraicType()
		{
			return SpacetimeDB.SATS.AlgebraicType.CreateProductType(new SpacetimeDB.SATS.ProductTypeElement[]
			{
				new SpacetimeDB.SATS.ProductTypeElement("id", SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.U32)),
				new SpacetimeDB.SATS.ProductTypeElement("position", SpacetimeDB.Types.Vector2.GetAlgebraicType()),
				new SpacetimeDB.SATS.ProductTypeElement("mass", SpacetimeDB.SATS.AlgebraicType.CreatePrimitiveType(SpacetimeDB.SATS.BuiltinType.Type.U32)),
			});
		}

		public static explicit operator Entity(SpacetimeDB.SATS.AlgebraicValue value)
		{
			if (value == null) {
				return null;
			}
			var productValue = value.AsProductValue();
			return new Entity
			{
				Id = productValue.elements[0].AsU32(),
				Position = (SpacetimeDB.Types.Vector2)(productValue.elements[1]),
				Mass = productValue.elements[2].AsU32(),
			};
		}

		public static System.Collections.Generic.IEnumerable<Entity> Iter()
		{
			foreach(var entry in SpacetimeDBClient.clientDB.GetEntries("Entity"))
			{
				yield return (Entity)entry.Item2;
			}
		}
		public static int Count()
		{
			return SpacetimeDBClient.clientDB.Count("Entity");
		}
		public static Entity FilterById(uint value)
		{
			Id_Index.TryGetValue(value, out var r);
			return r;
		}

		public static System.Collections.Generic.IEnumerable<Entity> FilterByMass(uint value)
		{
			foreach(var entry in SpacetimeDBClient.clientDB.GetEntries("Entity"))
			{
				var productValue = entry.Item1.AsProductValue();
				var compareValue = (uint)productValue.elements[2].AsU32();
				if (compareValue == value) {
					yield return (Entity)entry.Item2;
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

		public delegate void InsertEventHandler(Entity insertedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void UpdateEventHandler(Entity oldValue, Entity newValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void DeleteEventHandler(Entity deletedValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public delegate void RowUpdateEventHandler(SpacetimeDBClient.TableOp op, Entity oldValue, Entity newValue, SpacetimeDB.Types.ReducerEvent dbEvent);
		public static event InsertEventHandler OnInsert;
		public static event UpdateEventHandler OnUpdate;
		public static event DeleteEventHandler OnBeforeDelete;
		public static event DeleteEventHandler OnDelete;
		public static event RowUpdateEventHandler OnRowUpdate;

		public static void OnInsertEvent(object newValue, ClientApi.Event dbEvent)
		{
			OnInsert?.Invoke((Entity)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnUpdateEvent(object oldValue, object newValue, ClientApi.Event dbEvent)
		{
			OnUpdate?.Invoke((Entity)oldValue,(Entity)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnBeforeDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnBeforeDelete?.Invoke((Entity)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnDeleteEvent(object oldValue, ClientApi.Event dbEvent)
		{
			OnDelete?.Invoke((Entity)oldValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}

		public static void OnRowUpdateEvent(SpacetimeDBClient.TableOp op, object oldValue, object newValue, ClientApi.Event dbEvent)
		{
			OnRowUpdate?.Invoke(op, (Entity)oldValue,(Entity)newValue,(ReducerEvent)dbEvent?.FunctionCall.CallInfo);
		}
	}
}
