namespace XmlShouldSerializeSerialization
{
    #region Namespace

    using System.IO;
    using System.Text;

    #endregion

    /// <summary>
    /// Represents string writer with configuration encoding.
    /// </summary>
    public sealed class ExtentedStringWriter : StringWriter
    {
        /// <summary>
        /// Instance of encoding.
        /// </summary>
        private readonly Encoding stringWriterEncoding;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtentedStringWriter"/> class.
        /// </summary>
        /// <param name="builder">String builder instance.</param>
        /// <param name="desiredEncoding">Encoding desired.</param>
        public ExtentedStringWriter(StringBuilder builder, Encoding desiredEncoding)
            : base(builder)
        {
            this.stringWriterEncoding = desiredEncoding;
        }

        /// <summary>
        /// Gets current encoding used for string writer.
        /// </summary>
        public override Encoding Encoding
        {
            get
            {
                return this.stringWriterEncoding;
            }
        }
    }
}