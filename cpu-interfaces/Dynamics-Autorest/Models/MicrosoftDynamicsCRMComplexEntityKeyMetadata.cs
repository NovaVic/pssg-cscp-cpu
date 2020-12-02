// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ComplexEntityKeyMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexEntityKeyMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexEntityKeyMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexEntityKeyMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexEntityKeyMetadata class.
        /// </summary>
        /// <param name="entityKeyIndexStatus">Possible values include:
        /// 'Pending', 'InProgress', 'Active', 'Failed'</param>
        public MicrosoftDynamicsCRMComplexEntityKeyMetadata(MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string logicalName = default(string), string schemaName = default(string), string entityLogicalName = default(string), IList<string> keyAttributes = default(IList<string>), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isManaged = default(bool?), string introducedVersion = default(string), string entityKeyIndexStatus = default(string), string metadataId = default(string), bool? hasChanged = default(bool?))
        {
            DisplayName = displayName;
            LogicalName = logicalName;
            SchemaName = schemaName;
            EntityLogicalName = entityLogicalName;
            KeyAttributes = keyAttributes;
            IsCustomizable = isCustomizable;
            IsManaged = isManaged;
            IntroducedVersion = introducedVersion;
            EntityKeyIndexStatus = entityKeyIndexStatus;
            MetadataId = metadataId;
            HasChanged = hasChanged;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public MicrosoftDynamicsCRMLabel DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityLogicalName")]
        public string EntityLogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KeyAttributes")]
        public IList<string> KeyAttributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'InProgress',
        /// 'Active', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "EntityKeyIndexStatus")]
        public string EntityKeyIndexStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

    }
}
