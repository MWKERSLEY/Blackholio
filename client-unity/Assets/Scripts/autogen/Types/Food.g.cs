// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class Food
    {
        [DataMember(Name = "entity_id")]
        public uint EntityId;

        public Food(uint EntityId)
        {
            this.EntityId = EntityId;
        }

        public Food()
        {
        }
    }
}
