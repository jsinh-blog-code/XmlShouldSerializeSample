namespace XmlShouldSerializeSerialization
{
    using System;
    using System.Text;
    using System.IO;
    using System.Xml.Serialization;

    static class Program
    {
        static void Main(string[] args)
        {
            var employeeDetail = new Employee() { FirstName = "Mister", LastName = "XYZ" };
            var employeeDetailWithShouldSerialize = new EmployeeWithShouldSerialize { FirstName = "Mister", LastName = "ABC" };
            var employeeDetailXml = SerializeXml(employeeDetail);
            var employeeDetailWithShouldSerializeXml = SerializeXml(employeeDetailWithShouldSerialize);
            Console.Read();
        }

        /// <summary>
        /// Serialize XML.
        /// </summary>
        /// <typeparam name="T">Type of object to serialize.</typeparam>
        /// <param name="instanceToSerialize">Object to serialize.</param>
        /// <returns>Returns XML string.</returns>
        public static string SerializeXml<T>(T instanceToSerialize)
        {
            var serializer = new XmlSerializer(instanceToSerialize.GetType(), string.Empty);
            var stringBuilder = new StringBuilder();
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, instanceToSerialize);
                stringBuilder.Append(stringWriter);
            }

            return stringBuilder.ToString();
        }
    }
}
