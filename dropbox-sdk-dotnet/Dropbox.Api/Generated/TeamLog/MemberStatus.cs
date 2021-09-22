// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The member status object</para>
    /// </summary>
    public class MemberStatus
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberStatus> Encoder = new MemberStatusEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberStatus> Decoder = new MemberStatusDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberStatus" /> class.</para>
        /// </summary>
        public MemberStatus()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Active</para>
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this is Active;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Active, or <c>null</c>.</para>
        /// </summary>
        public Active AsActive
        {
            get
            {
                return this as Active;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Invited</para>
        /// </summary>
        public bool IsInvited
        {
            get
            {
                return this is Invited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Invited, or <c>null</c>.</para>
        /// </summary>
        public Invited AsInvited
        {
            get
            {
                return this as Invited;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MovedToAnotherTeam</para>
        /// </summary>
        public bool IsMovedToAnotherTeam
        {
            get
            {
                return this is MovedToAnotherTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MovedToAnotherTeam, or <c>null</c>.</para>
        /// </summary>
        public MovedToAnotherTeam AsMovedToAnotherTeam
        {
            get
            {
                return this as MovedToAnotherTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotJoined</para>
        /// </summary>
        public bool IsNotJoined
        {
            get
            {
                return this is NotJoined;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotJoined, or <c>null</c>.</para>
        /// </summary>
        public NotJoined AsNotJoined
        {
            get
            {
                return this as NotJoined;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Removed</para>
        /// </summary>
        public bool IsRemoved
        {
            get
            {
                return this is Removed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Removed, or <c>null</c>.</para>
        /// </summary>
        public Removed AsRemoved
        {
            get
            {
                return this as Removed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Suspended</para>
        /// </summary>
        public bool IsSuspended
        {
            get
            {
                return this is Suspended;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Suspended, or <c>null</c>.</para>
        /// </summary>
        public Suspended AsSuspended
        {
            get
            {
                return this as Suspended;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberStatus" />.</para>
        /// </summary>
        private class MemberStatusEncoder : enc.StructEncoder<MemberStatus>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberStatus value, enc.IJsonWriter writer)
            {
                if (value is Active)
                {
                    WriteProperty(".tag", "active", writer, enc.StringEncoder.Instance);
                    Active.Encoder.EncodeFields((Active)value, writer);
                    return;
                }
                if (value is Invited)
                {
                    WriteProperty(".tag", "invited", writer, enc.StringEncoder.Instance);
                    Invited.Encoder.EncodeFields((Invited)value, writer);
                    return;
                }
                if (value is MovedToAnotherTeam)
                {
                    WriteProperty(".tag", "moved_to_another_team", writer, enc.StringEncoder.Instance);
                    MovedToAnotherTeam.Encoder.EncodeFields((MovedToAnotherTeam)value, writer);
                    return;
                }
                if (value is NotJoined)
                {
                    WriteProperty(".tag", "not_joined", writer, enc.StringEncoder.Instance);
                    NotJoined.Encoder.EncodeFields((NotJoined)value, writer);
                    return;
                }
                if (value is Removed)
                {
                    WriteProperty(".tag", "removed", writer, enc.StringEncoder.Instance);
                    Removed.Encoder.EncodeFields((Removed)value, writer);
                    return;
                }
                if (value is Suspended)
                {
                    WriteProperty(".tag", "suspended", writer, enc.StringEncoder.Instance);
                    Suspended.Encoder.EncodeFields((Suspended)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberStatus" />.</para>
        /// </summary>
        private class MemberStatusDecoder : enc.UnionDecoder<MemberStatus>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberStatus" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberStatus Create()
            {
                return new MemberStatus();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MemberStatus Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "active":
                        return Active.Decoder.DecodeFields(reader);
                    case "invited":
                        return Invited.Decoder.DecodeFields(reader);
                    case "moved_to_another_team":
                        return MovedToAnotherTeam.Decoder.DecodeFields(reader);
                    case "not_joined":
                        return NotJoined.Decoder.DecodeFields(reader);
                    case "removed":
                        return Removed.Decoder.DecodeFields(reader);
                    case "suspended":
                        return Suspended.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The active object</para>
        /// </summary>
        public sealed class Active : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Active> Encoder = new ActiveEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Active> Decoder = new ActiveDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Active" /> class.</para>
            /// </summary>
            private Active()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Active</para>
            /// </summary>
            public static readonly Active Instance = new Active();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Active" />.</para>
            /// </summary>
            private class ActiveEncoder : enc.StructEncoder<Active>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Active value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Active" />.</para>
            /// </summary>
            private class ActiveDecoder : enc.StructDecoder<Active>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Active" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Active Create()
                {
                    return Active.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The invited object</para>
        /// </summary>
        public sealed class Invited : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Invited> Encoder = new InvitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Invited> Decoder = new InvitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Invited" /> class.</para>
            /// </summary>
            private Invited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Invited</para>
            /// </summary>
            public static readonly Invited Instance = new Invited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedEncoder : enc.StructEncoder<Invited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Invited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedDecoder : enc.StructDecoder<Invited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Invited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Invited Create()
                {
                    return Invited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The moved to another team object</para>
        /// </summary>
        public sealed class MovedToAnotherTeam : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MovedToAnotherTeam> Encoder = new MovedToAnotherTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MovedToAnotherTeam> Decoder = new MovedToAnotherTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MovedToAnotherTeam" />
            /// class.</para>
            /// </summary>
            private MovedToAnotherTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of MovedToAnotherTeam</para>
            /// </summary>
            public static readonly MovedToAnotherTeam Instance = new MovedToAnotherTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MovedToAnotherTeam" />.</para>
            /// </summary>
            private class MovedToAnotherTeamEncoder : enc.StructEncoder<MovedToAnotherTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MovedToAnotherTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MovedToAnotherTeam" />.</para>
            /// </summary>
            private class MovedToAnotherTeamDecoder : enc.StructDecoder<MovedToAnotherTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MovedToAnotherTeam"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MovedToAnotherTeam Create()
                {
                    return MovedToAnotherTeam.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The not joined object</para>
        /// </summary>
        public sealed class NotJoined : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotJoined> Encoder = new NotJoinedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotJoined> Decoder = new NotJoinedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotJoined" /> class.</para>
            /// </summary>
            private NotJoined()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotJoined</para>
            /// </summary>
            public static readonly NotJoined Instance = new NotJoined();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotJoined" />.</para>
            /// </summary>
            private class NotJoinedEncoder : enc.StructEncoder<NotJoined>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotJoined value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotJoined" />.</para>
            /// </summary>
            private class NotJoinedDecoder : enc.StructDecoder<NotJoined>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotJoined" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotJoined Create()
                {
                    return NotJoined.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The removed object</para>
        /// </summary>
        public sealed class Removed : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Removed> Encoder = new RemovedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Removed> Decoder = new RemovedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Removed" /> class.</para>
            /// </summary>
            private Removed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Removed</para>
            /// </summary>
            public static readonly Removed Instance = new Removed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Removed" />.</para>
            /// </summary>
            private class RemovedEncoder : enc.StructEncoder<Removed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Removed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Removed" />.</para>
            /// </summary>
            private class RemovedDecoder : enc.StructDecoder<Removed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Removed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Removed Create()
                {
                    return Removed.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The suspended object</para>
        /// </summary>
        public sealed class Suspended : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Suspended> Encoder = new SuspendedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Suspended> Decoder = new SuspendedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Suspended" /> class.</para>
            /// </summary>
            private Suspended()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Suspended</para>
            /// </summary>
            public static readonly Suspended Instance = new Suspended();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Suspended" />.</para>
            /// </summary>
            private class SuspendedEncoder : enc.StructEncoder<Suspended>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Suspended value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Suspended" />.</para>
            /// </summary>
            private class SuspendedDecoder : enc.StructDecoder<Suspended>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Suspended" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Suspended Create()
                {
                    return Suspended.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MemberStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}