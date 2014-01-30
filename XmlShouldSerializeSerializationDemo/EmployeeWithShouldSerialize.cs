namespace XmlShouldSerializeSerialization
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// Employee model with should serialize.
    /// </summary>
    ////[Serializable]
    [XmlRoot("Employee")]
    public sealed class EmployeeWithShouldSerialize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWithShouldSerialize"/> class.
        /// </summary>
        public EmployeeWithShouldSerialize()
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

        /// <summary>
        /// Ensures the list of skills will not appear if skill list is empty and the instance is serialized.
        /// </summary>
        public bool ShouldSerializeSkills()
        {
            return null != this.Skills && this.Skills.Any();
        }
    }
}
