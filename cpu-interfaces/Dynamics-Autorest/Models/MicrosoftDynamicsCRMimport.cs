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
    /// import
    /// </summary>
    public partial class MicrosoftDynamicsCRMimport
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimport class.
        /// </summary>
        public MicrosoftDynamicsCRMimport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimport class.
        /// </summary>
        public MicrosoftDynamicsCRMimport(string importid = default(string), string _createdbyValue = default(string), string emailaddress = default(string), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? modecode = default(int?), int? statecode = default(int?), string _modifiedbyValue = default(string), string _createdonbehalfbyValue = default(string), string name = default(string), string _owninguserValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), bool? sendnotification = default(bool?), int? sequence = default(int?), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMimportfile> importImportFile = default(IList<MicrosoftDynamicsCRMimportfile>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> importBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> importAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            Importid = importid;
            this._createdbyValue = _createdbyValue;
            Emailaddress = emailaddress;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            Modecode = modecode;
            Statecode = statecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Name = name;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Sendnotification = sendnotification;
            Sequence = sequence;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Createdby = createdby;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Createdonbehalfby = createdonbehalfby;
            ImportImportFile = importImportFile;
            Ownerid = ownerid;
            Modifiedonbehalfby = modifiedonbehalfby;
            ImportBulkDeleteFailures = importBulkDeleteFailures;
            Owningbusinessunit = owningbusinessunit;
            Modifiedby = modifiedby;
            ImportAsyncOperations = importAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importid")]
        public string Importid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modecode")]
        public int? Modecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendnotification")]
        public bool? Sendnotification { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Import_ImportFile")]
        public IList<MicrosoftDynamicsCRMimportfile> ImportImportFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Import_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ImportBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Import_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ImportAsyncOperations { get; set; }

    }
}
