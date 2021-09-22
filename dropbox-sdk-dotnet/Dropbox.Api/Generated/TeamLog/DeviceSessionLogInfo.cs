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
    /// <para>Device's session logged information.</para>
    /// </summary>
    /// <seealso cref="DesktopDeviceSessionLogInfo" />
    /// <seealso cref="DeviceChangeIpDesktopDetails" />
    /// <seealso cref="LegacyDeviceSessionLogInfo" />
    /// <seealso cref="MobileDeviceSessionLogInfo" />
    /// <seealso cref="WebDeviceSessionLogInfo" />
    public class DeviceSessionLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceSessionLogInfo> Encoder = new DeviceSessionLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceSessionLogInfo> Decoder = new DeviceSessionLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="ipAddress">The IP address of the last activity from this
        /// session.</param>
        /// <param name="created">The time this session was created.</param>
        /// <param name="updated">The time of the last activity from this session.</param>
        protected DeviceSessionLogInfo(string ipAddress = null,
                                       sys.DateTime? created = null,
                                       sys.DateTime? updated = null)
        {
            this.IpAddress = ipAddress;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceSessionLogInfo()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DesktopDeviceSession</para>
        /// </summary>
        public bool IsDesktopDeviceSession
        {
            get
            {
                return this is DesktopDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="DesktopDeviceSessionLogInfo" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public DesktopDeviceSessionLogInfo AsDesktopDeviceSession
        {
            get
            {
                return this as DesktopDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MobileDeviceSession</para>
        /// </summary>
        public bool IsMobileDeviceSession
        {
            get
            {
                return this is MobileDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="MobileDeviceSessionLogInfo" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public MobileDeviceSessionLogInfo AsMobileDeviceSession
        {
            get
            {
                return this as MobileDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is WebDeviceSession</para>
        /// </summary>
        public bool IsWebDeviceSession
        {
            get
            {
                return this is WebDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="WebDeviceSessionLogInfo" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public WebDeviceSessionLogInfo AsWebDeviceSession
        {
            get
            {
                return this as WebDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is LegacyDeviceSession</para>
        /// </summary>
        public bool IsLegacyDeviceSession
        {
            get
            {
                return this is LegacyDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="LegacyDeviceSessionLogInfo" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public LegacyDeviceSessionLogInfo AsLegacyDeviceSession
        {
            get
            {
                return this as LegacyDeviceSessionLogInfo;
            }
        }

        /// <summary>
        /// <para>The IP address of the last activity from this session.</para>
        /// </summary>
        public string IpAddress { get; protected set; }

        /// <summary>
        /// <para>The time this session was created.</para>
        /// </summary>
        public sys.DateTime? Created { get; protected set; }

        /// <summary>
        /// <para>The time of the last activity from this session.</para>
        /// </summary>
        public sys.DateTime? Updated { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceSessionLogInfo" />.</para>
        /// </summary>
        private class DeviceSessionLogInfoEncoder : enc.StructEncoder<DeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceSessionLogInfo value, enc.IJsonWriter writer)
            {
                if (value is DesktopDeviceSessionLogInfo)
                {
                    WriteProperty(".tag", "desktop_device_session", writer, enc.StringEncoder.Instance);
                    DesktopDeviceSessionLogInfo.Encoder.EncodeFields((DesktopDeviceSessionLogInfo)value, writer);
                    return;
                }
                if (value is MobileDeviceSessionLogInfo)
                {
                    WriteProperty(".tag", "mobile_device_session", writer, enc.StringEncoder.Instance);
                    MobileDeviceSessionLogInfo.Encoder.EncodeFields((MobileDeviceSessionLogInfo)value, writer);
                    return;
                }
                if (value is WebDeviceSessionLogInfo)
                {
                    WriteProperty(".tag", "web_device_session", writer, enc.StringEncoder.Instance);
                    WebDeviceSessionLogInfo.Encoder.EncodeFields((WebDeviceSessionLogInfo)value, writer);
                    return;
                }
                if (value is LegacyDeviceSessionLogInfo)
                {
                    WriteProperty(".tag", "legacy_device_session", writer, enc.StringEncoder.Instance);
                    LegacyDeviceSessionLogInfo.Encoder.EncodeFields((LegacyDeviceSessionLogInfo)value, writer);
                    return;
                }
                if (value.IpAddress != null)
                {
                    WriteProperty("ip_address", value.IpAddress, writer, enc.StringEncoder.Instance);
                }
                if (value.Created != null)
                {
                    WriteProperty("created", value.Created.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.Updated != null)
                {
                    WriteProperty("updated", value.Updated.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceSessionLogInfo" />.</para>
        /// </summary>
        private class DeviceSessionLogInfoDecoder : enc.UnionDecoder<DeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceSessionLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceSessionLogInfo Create()
            {
                return new DeviceSessionLogInfo();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeviceSessionLogInfo Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "desktop_device_session":
                        return DesktopDeviceSessionLogInfo.Decoder.DecodeFields(reader);
                    case "mobile_device_session":
                        return MobileDeviceSessionLogInfo.Decoder.DecodeFields(reader);
                    case "web_device_session":
                        return WebDeviceSessionLogInfo.Decoder.DecodeFields(reader);
                    case "legacy_device_session":
                        return LegacyDeviceSessionLogInfo.Decoder.DecodeFields(reader);
                    default:
                        return base.Decode(reader);
                }
            }
            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceSessionLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "ip_address":
                        value.IpAddress = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "created":
                        value.Created = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "updated":
                        value.Updated = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}