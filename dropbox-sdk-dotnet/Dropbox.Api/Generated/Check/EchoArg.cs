// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Check
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>EchoArg contains the arguments to be sent to the Dropbox servers.</para>
    /// </summary>
    public class EchoArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EchoArg> Encoder = new EchoArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EchoArg> Decoder = new EchoArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EchoArg" /> class.</para>
        /// </summary>
        /// <param name="query">The string that you'd like to be echoed back to you.</param>
        public EchoArg(string query = "")
        {
            if (query == null)
            {
                throw new sys.ArgumentNullException("query");
            }

            this.Query = query;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EchoArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public EchoArg()
        {
            this.Query = "";
        }

        /// <summary>
        /// <para>The string that you'd like to be echoed back to you.</para>
        /// </summary>
        public string Query { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EchoArg" />.</para>
        /// </summary>
        private class EchoArgEncoder : enc.StructEncoder<EchoArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EchoArg value, enc.IJsonWriter writer)
            {
                WriteProperty("query", value.Query, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EchoArg" />.</para>
        /// </summary>
        private class EchoArgDecoder : enc.StructDecoder<EchoArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EchoArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EchoArg Create()
            {
                return new EchoArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EchoArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "query":
                        value.Query = enc.StringDecoder.Instance.Decode(reader);
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