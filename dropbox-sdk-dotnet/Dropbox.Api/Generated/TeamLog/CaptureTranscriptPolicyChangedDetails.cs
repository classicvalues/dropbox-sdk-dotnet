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
    /// <para>Changed Capture transcription policy for team.</para>
    /// </summary>
    public class CaptureTranscriptPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CaptureTranscriptPolicyChangedDetails> Encoder = new CaptureTranscriptPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CaptureTranscriptPolicyChangedDetails> Decoder = new CaptureTranscriptPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="CaptureTranscriptPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">To.</param>
        /// <param name="previousValue">From.</param>
        public CaptureTranscriptPolicyChangedDetails(CaptureTranscriptPolicy newValue,
                                                     CaptureTranscriptPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="CaptureTranscriptPolicyChangedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CaptureTranscriptPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>To.</para>
        /// </summary>
        public CaptureTranscriptPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>From.</para>
        /// </summary>
        public CaptureTranscriptPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CaptureTranscriptPolicyChangedDetails" />.</para>
        /// </summary>
        private class CaptureTranscriptPolicyChangedDetailsEncoder : enc.StructEncoder<CaptureTranscriptPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CaptureTranscriptPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.CaptureTranscriptPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.CaptureTranscriptPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CaptureTranscriptPolicyChangedDetails" />.</para>
        /// </summary>
        private class CaptureTranscriptPolicyChangedDetailsDecoder : enc.StructDecoder<CaptureTranscriptPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="CaptureTranscriptPolicyChangedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CaptureTranscriptPolicyChangedDetails Create()
            {
                return new CaptureTranscriptPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CaptureTranscriptPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.CaptureTranscriptPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.CaptureTranscriptPolicy.Decoder.Decode(reader);
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