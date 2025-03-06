// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteReducers : RemoteBase
    {
        public delegate void PlayerSplitHandler(ReducerEventContext ctx);
        public event PlayerSplitHandler? OnPlayerSplit;

        public void PlayerSplit()
        {
            conn.InternalCallReducer(new Reducer.PlayerSplit(), this.SetCallReducerFlags.PlayerSplitFlags);
        }

        public bool InvokePlayerSplit(ReducerEventContext ctx, Reducer.PlayerSplit args)
        {
            if (OnPlayerSplit == null) return false;
            OnPlayerSplit(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class PlayerSplit : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "PlayerSplit";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerSplitFlags;
        public void PlayerSplit(CallReducerFlags flags) => PlayerSplitFlags = flags;
    }
}
