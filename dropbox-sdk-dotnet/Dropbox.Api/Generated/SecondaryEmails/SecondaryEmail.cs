// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.SecondaryEmails
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The secondary email object</para>
    /// </summary>
    public class SecondaryEmail
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SecondaryEmail> Encoder = new SecondaryEmailEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SecondaryEmail> Decoder = new SecondaryEmailDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SecondaryEmail" /> class.</para>
        /// </summary>
        /// <param name="email">Secondary email address.</param>
        /// <param name="isVerified">Whether or not the secondary email address is verified to
        /// be owned by a user.</param>
        public SecondaryEmail(string email,
                              bool isVerified)
        {
            if (email == null)
            {
                throw new sys.ArgumentNullException("email");
            }
            if (email.Length > 255)
            {
                throw new sys.ArgumentOutOfRangeException("email", "Length should be at most 255");
            }
            if (!re.Regex.IsMatch(email, @"\A(?:^['#&A-Za-z0-9._%+-]+@[A-Za-z0-9-][A-Za-z0-9.-]*\.[A-Za-z]{2,15}$)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("email", @"Value should match pattern '\A(?:^['#&A-Za-z0-9._%+-]+@[A-Za-z0-9-][A-Za-z0-9.-]*\.[A-Za-z]{2,15}$)\z'");
            }

            this.Email = email;
            this.IsVerified = isVerified;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SecondaryEmail" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SecondaryEmail()
        {
        }

        /// <summary>
        /// <para>Secondary email address.</para>
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// <para>Whether or not the secondary email address is verified to be owned by a
        /// user.</para>
        /// </summary>
        public bool IsVerified { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SecondaryEmail" />.</para>
        /// </summary>
        private class SecondaryEmailEncoder : enc.StructEncoder<SecondaryEmail>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SecondaryEmail value, enc.IJsonWriter writer)
            {
                WriteProperty("email", value.Email, writer, enc.StringEncoder.Instance);
                WriteProperty("is_verified", value.IsVerified, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SecondaryEmail" />.</para>
        /// </summary>
        private class SecondaryEmailDecoder : enc.StructDecoder<SecondaryEmail>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SecondaryEmail" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SecondaryEmail Create()
            {
                return new SecondaryEmail();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SecondaryEmail value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "email":
                        value.Email = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "is_verified":
                        value.IsVerified = enc.BooleanDecoder.Instance.Decode(reader);
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
