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
        public sealed class PlayerHandle : RemoteTableHandle<EventContext, Player>
        {
            public override void InternalInvokeValueInserted(IStructuralReadWrite row)
            {
                var value = (Player)row;
                Identity.Cache[value.Identity] = value;
                PlayerId.Cache[value.PlayerId] = value;
            }

            public override void InternalInvokeValueDeleted(IStructuralReadWrite row)
            {
                Identity.Cache.Remove(((Player)row).Identity);
                PlayerId.Cache.Remove(((Player)row).PlayerId);
            }

            public sealed class IdentityUniqueIndex
            {
                internal readonly Dictionary<SpacetimeDB.Identity, Player> Cache = new(16);

                public Player? Find(SpacetimeDB.Identity value)
                {
                    Cache.TryGetValue(value, out var r);
                    return r;
                }
            }

            public IdentityUniqueIndex Identity = new();

            public sealed class PlayerIdUniqueIndex
            {
                internal readonly Dictionary<uint, Player> Cache = new(16);

                public Player? Find(uint value)
                {
                    Cache.TryGetValue(value, out var r);
                    return r;
                }
            }

            public PlayerIdUniqueIndex PlayerId = new();

            internal PlayerHandle()
            {
            }

            public override object GetPrimaryKey(IStructuralReadWrite row) => ((Player)row).Identity;
        }

        public readonly PlayerHandle Player = new();
    }
}
