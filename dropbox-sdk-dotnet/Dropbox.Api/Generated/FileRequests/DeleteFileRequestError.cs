// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileRequests
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>There was an error deleting these file requests.</para>
    /// </summary>
    public class DeleteFileRequestError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeleteFileRequestError> Encoder = new DeleteFileRequestErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeleteFileRequestError> Decoder = new DeleteFileRequestErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeleteFileRequestError" />
        /// class.</para>
        /// </summary>
        public DeleteFileRequestError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FileRequestOpen</para>
        /// </summary>
        public bool IsFileRequestOpen
        {
            get
            {
                return this is FileRequestOpen;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FileRequestOpen, or <c>null</c>.</para>
        /// </summary>
        public FileRequestOpen AsFileRequestOpen
        {
            get
            {
                return this as FileRequestOpen;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotAFolder</para>
        /// </summary>
        public bool IsNotAFolder
        {
            get
            {
                return this is NotAFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotAFolder, or <c>null</c>.</para>
        /// </summary>
        public NotAFolder AsNotAFolder
        {
            get
            {
                return this as NotAFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AppLacksAccess</para>
        /// </summary>
        public bool IsAppLacksAccess
        {
            get
            {
                return this is AppLacksAccess;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AppLacksAccess, or <c>null</c>.</para>
        /// </summary>
        public AppLacksAccess AsAppLacksAccess
        {
            get
            {
                return this as AppLacksAccess;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EmailUnverified</para>
        /// </summary>
        public bool IsEmailUnverified
        {
            get
            {
                return this is EmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EmailUnverified, or <c>null</c>.</para>
        /// </summary>
        public EmailUnverified AsEmailUnverified
        {
            get
            {
                return this as EmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ValidationError</para>
        /// </summary>
        public bool IsValidationError
        {
            get
            {
                return this is ValidationError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ValidationError, or <c>null</c>.</para>
        /// </summary>
        public ValidationError AsValidationError
        {
            get
            {
                return this as ValidationError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DisabledForTeam</para>
        /// </summary>
        public bool IsDisabledForTeam
        {
            get
            {
                return this is DisabledForTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DisabledForTeam, or <c>null</c>.</para>
        /// </summary>
        public DisabledForTeam AsDisabledForTeam
        {
            get
            {
                return this as DisabledForTeam;
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
        /// <para>Encoder for  <see cref="DeleteFileRequestError" />.</para>
        /// </summary>
        private class DeleteFileRequestErrorEncoder : enc.StructEncoder<DeleteFileRequestError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeleteFileRequestError value, enc.IJsonWriter writer)
            {
                if (value is FileRequestOpen)
                {
                    WriteProperty(".tag", "file_request_open", writer, enc.StringEncoder.Instance);
                    FileRequestOpen.Encoder.EncodeFields((FileRequestOpen)value, writer);
                    return;
                }
                if (value is NotFound)
                {
                    WriteProperty(".tag", "not_found", writer, enc.StringEncoder.Instance);
                    NotFound.Encoder.EncodeFields((NotFound)value, writer);
                    return;
                }
                if (value is NotAFolder)
                {
                    WriteProperty(".tag", "not_a_folder", writer, enc.StringEncoder.Instance);
                    NotAFolder.Encoder.EncodeFields((NotAFolder)value, writer);
                    return;
                }
                if (value is AppLacksAccess)
                {
                    WriteProperty(".tag", "app_lacks_access", writer, enc.StringEncoder.Instance);
                    AppLacksAccess.Encoder.EncodeFields((AppLacksAccess)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is EmailUnverified)
                {
                    WriteProperty(".tag", "email_unverified", writer, enc.StringEncoder.Instance);
                    EmailUnverified.Encoder.EncodeFields((EmailUnverified)value, writer);
                    return;
                }
                if (value is ValidationError)
                {
                    WriteProperty(".tag", "validation_error", writer, enc.StringEncoder.Instance);
                    ValidationError.Encoder.EncodeFields((ValidationError)value, writer);
                    return;
                }
                if (value is DisabledForTeam)
                {
                    WriteProperty(".tag", "disabled_for_team", writer, enc.StringEncoder.Instance);
                    DisabledForTeam.Encoder.EncodeFields((DisabledForTeam)value, writer);
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
        /// <para>Decoder for  <see cref="DeleteFileRequestError" />.</para>
        /// </summary>
        private class DeleteFileRequestErrorDecoder : enc.UnionDecoder<DeleteFileRequestError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeleteFileRequestError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeleteFileRequestError Create()
            {
                return new DeleteFileRequestError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeleteFileRequestError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "file_request_open":
                        return FileRequestOpen.Decoder.DecodeFields(reader);
                    case "not_found":
                        return NotFound.Decoder.DecodeFields(reader);
                    case "not_a_folder":
                        return NotAFolder.Decoder.DecodeFields(reader);
                    case "app_lacks_access":
                        return AppLacksAccess.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    case "email_unverified":
                        return EmailUnverified.Decoder.DecodeFields(reader);
                    case "validation_error":
                        return ValidationError.Decoder.DecodeFields(reader);
                    case "disabled_for_team":
                        return DisabledForTeam.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>One or more file requests currently open.</para>
        /// </summary>
        public sealed class FileRequestOpen : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FileRequestOpen> Encoder = new FileRequestOpenEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FileRequestOpen> Decoder = new FileRequestOpenDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FileRequestOpen" />
            /// class.</para>
            /// </summary>
            private FileRequestOpen()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FileRequestOpen</para>
            /// </summary>
            public static readonly FileRequestOpen Instance = new FileRequestOpen();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FileRequestOpen" />.</para>
            /// </summary>
            private class FileRequestOpenEncoder : enc.StructEncoder<FileRequestOpen>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FileRequestOpen value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FileRequestOpen" />.</para>
            /// </summary>
            private class FileRequestOpenDecoder : enc.StructDecoder<FileRequestOpen>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FileRequestOpen" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FileRequestOpen Create()
                {
                    return FileRequestOpen.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This file request ID was not found.</para>
        /// </summary>
        public sealed class NotFound : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFound> Encoder = new NotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFound> Decoder = new NotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundEncoder : enc.StructEncoder<NotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundDecoder : enc.StructDecoder<NotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFound Create()
                {
                    return NotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The specified path is not a folder.</para>
        /// </summary>
        public sealed class NotAFolder : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotAFolder> Encoder = new NotAFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotAFolder> Decoder = new NotAFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotAFolder" /> class.</para>
            /// </summary>
            private NotAFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotAFolder</para>
            /// </summary>
            public static readonly NotAFolder Instance = new NotAFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotAFolder" />.</para>
            /// </summary>
            private class NotAFolderEncoder : enc.StructEncoder<NotAFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotAFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotAFolder" />.</para>
            /// </summary>
            private class NotAFolderDecoder : enc.StructDecoder<NotAFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotAFolder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotAFolder Create()
                {
                    return NotAFolder.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This file request is not accessible to this app. Apps with the app folder
        /// permission can only access file requests in their app folder.</para>
        /// </summary>
        public sealed class AppLacksAccess : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AppLacksAccess> Encoder = new AppLacksAccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AppLacksAccess> Decoder = new AppLacksAccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AppLacksAccess" />
            /// class.</para>
            /// </summary>
            private AppLacksAccess()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AppLacksAccess</para>
            /// </summary>
            public static readonly AppLacksAccess Instance = new AppLacksAccess();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AppLacksAccess" />.</para>
            /// </summary>
            private class AppLacksAccessEncoder : enc.StructEncoder<AppLacksAccess>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AppLacksAccess value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AppLacksAccess" />.</para>
            /// </summary>
            private class AppLacksAccessDecoder : enc.StructDecoder<AppLacksAccess>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AppLacksAccess" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AppLacksAccess Create()
                {
                    return AppLacksAccess.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This user doesn't have permission to access or modify this file
        /// request.</para>
        /// </summary>
        public sealed class NoPermission : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return NoPermission.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This user's email address is not verified. File requests are only available
        /// on accounts with a verified email address. Users can verify their email address <a
        /// href="https://www.dropbox.com/help/317">here</a>.</para>
        /// </summary>
        public sealed class EmailUnverified : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EmailUnverified> Encoder = new EmailUnverifiedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EmailUnverified> Decoder = new EmailUnverifiedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EmailUnverified" />
            /// class.</para>
            /// </summary>
            private EmailUnverified()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EmailUnverified</para>
            /// </summary>
            public static readonly EmailUnverified Instance = new EmailUnverified();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EmailUnverified" />.</para>
            /// </summary>
            private class EmailUnverifiedEncoder : enc.StructEncoder<EmailUnverified>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EmailUnverified value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EmailUnverified" />.</para>
            /// </summary>
            private class EmailUnverifiedDecoder : enc.StructDecoder<EmailUnverified>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EmailUnverified" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EmailUnverified Create()
                {
                    return EmailUnverified.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>There was an error validating the request. For example, the title was
        /// invalid, or there were disallowed characters in the destination path.</para>
        /// </summary>
        public sealed class ValidationError : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ValidationError> Encoder = new ValidationErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ValidationError> Decoder = new ValidationErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ValidationError" />
            /// class.</para>
            /// </summary>
            private ValidationError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ValidationError</para>
            /// </summary>
            public static readonly ValidationError Instance = new ValidationError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ValidationError" />.</para>
            /// </summary>
            private class ValidationErrorEncoder : enc.StructEncoder<ValidationError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ValidationError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ValidationError" />.</para>
            /// </summary>
            private class ValidationErrorDecoder : enc.StructDecoder<ValidationError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ValidationError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ValidationError Create()
                {
                    return ValidationError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This user's Dropbox Business team doesn't allow file requests.</para>
        /// </summary>
        public sealed class DisabledForTeam : DeleteFileRequestError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DisabledForTeam> Encoder = new DisabledForTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DisabledForTeam> Decoder = new DisabledForTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DisabledForTeam" />
            /// class.</para>
            /// </summary>
            private DisabledForTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DisabledForTeam</para>
            /// </summary>
            public static readonly DisabledForTeam Instance = new DisabledForTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DisabledForTeam" />.</para>
            /// </summary>
            private class DisabledForTeamEncoder : enc.StructEncoder<DisabledForTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DisabledForTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DisabledForTeam" />.</para>
            /// </summary>
            private class DisabledForTeamDecoder : enc.StructDecoder<DisabledForTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DisabledForTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DisabledForTeam Create()
                {
                    return DisabledForTeam.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeleteFileRequestError
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
