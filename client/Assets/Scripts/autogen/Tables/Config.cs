// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

// <auto-generated />

#nullable enable

using System;
using SpacetimeDB.BSATN;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteTables
    {
        public sealed class ConfigHandle : RemoteTableHandle<EventContext, Config>
        {
            public override void InternalInvokeValueInserted(IStructuralReadWrite row)
            {
                var value = (Config)row;
                Id.Cache[value.Id] = value;
            }

            public override void InternalInvokeValueDeleted(IStructuralReadWrite row)
            {
                Id.Cache.Remove(((Config)row).Id);
            }

            public sealed class IdUniqueIndex
            {
                internal readonly Dictionary<uint, Config> Cache = new(16);

                public Config? Find(uint value)
                {
                    Cache.TryGetValue(value, out var r);
                    return r;
                }
            }

            public IdUniqueIndex Id = new();

            internal ConfigHandle()
            {
            }

            public override object GetPrimaryKey(IStructuralReadWrite row) => ((Config)row).Id;
        }

        public readonly ConfigHandle Config = new();
    }
}
