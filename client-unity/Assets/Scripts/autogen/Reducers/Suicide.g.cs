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
        public delegate void SuicideHandler(EventContext ctx);
        public event SuicideHandler? OnSuicide;

        public void Suicide()
        {
            conn.InternalCallReducer(new Reducer.Suicide(), this.SetCallReducerFlags.SuicideFlags);
        }

        public bool InvokeSuicide(EventContext ctx, Reducer.Suicide args)
        {
            if (OnSuicide == null) return false;
            OnSuicide(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class Suicide : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "suicide";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags SuicideFlags;
        public void Suicide(CallReducerFlags flags) => SuicideFlags = flags;
    }
}
