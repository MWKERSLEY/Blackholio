// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN RUST INSTEAD.

// <auto-generated />

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class CircleRecombineTimer
    {
        [DataMember(Name = "scheduled_id")]
        public ulong ScheduledId;
        [DataMember(Name = "scheduled_at")]
        public SpacetimeDB.ScheduleAt ScheduledAt;
        [DataMember(Name = "player_id")]
        public uint PlayerId;

        public CircleRecombineTimer(
            ulong ScheduledId,
            SpacetimeDB.ScheduleAt ScheduledAt,
            uint PlayerId
        )
        {
            this.ScheduledId = ScheduledId;
            this.ScheduledAt = ScheduledAt;
            this.PlayerId = PlayerId;
        }

        public CircleRecombineTimer()
        {
            this.ScheduledAt = null!;
        }
    }
}
