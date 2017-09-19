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
    /// <para>Change two-step verification policy for the team.</para>
    /// </summary>
    public class TfaChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TfaChangePolicyDetails> Encoder = new TfaChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TfaChangePolicyDetails> Decoder = new TfaChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TfaChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New change policy.</param>
        /// <param name="previousValue">Previous change policy. Might be missing due to
        /// historical data gap.</param>
        public TfaChangePolicyDetails(TfaPolicy newValue,
                                      TfaPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TfaChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TfaChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New change policy.</para>
        /// </summary>
        public TfaPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous change policy. Might be missing due to historical data gap.</para>
        /// </summary>
        public TfaPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TfaChangePolicyDetails" />.</para>
        /// </summary>
        private class TfaChangePolicyDetailsEncoder : enc.StructEncoder<TfaChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TfaChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.TfaPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.TfaPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TfaChangePolicyDetails" />.</para>
        /// </summary>
        private class TfaChangePolicyDetailsDecoder : enc.StructDecoder<TfaChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TfaChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TfaChangePolicyDetails Create()
            {
                return new TfaChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TfaChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.TfaPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.TfaPolicy.Decoder.Decode(reader);
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