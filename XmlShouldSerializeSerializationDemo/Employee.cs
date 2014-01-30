namespace XmlShouldSerializeSerialization
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.Skills = new List<string>();
        }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [XmlElement("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets list of skills of the employee.
        /// </summary>
        [XmlArray("Skills")]
        [XmlArrayItem("Skill")]
        public List<string> Skills { get; set; }
    }
}
