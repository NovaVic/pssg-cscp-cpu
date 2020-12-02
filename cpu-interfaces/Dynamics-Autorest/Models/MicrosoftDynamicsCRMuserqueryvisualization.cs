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
    /// userqueryvisualization
    /// </summary>
    public partial class MicrosoftDynamicsCRMuserqueryvisualization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMuserqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMuserqueryvisualization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMuserqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMuserqueryvisualization(long? versionnumber = default(long?), string _webresourceidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string primaryentitytypecode = default(string), string _modifiedbyValue = default(string), string datadescription = default(string), bool? isdefault = default(bool?), string userqueryvisualizationid = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string name = default(string), string presentationdescription = default(string), int? charttype = default(int?), string _createdbyValue = default(string), string _owninguserValue = default(string), string description = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> userQueryVisualizationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMwebresource webresourceid = default(MicrosoftDynamicsCRMwebresource), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Versionnumber = versionnumber;
            this._webresourceidValue = _webresourceidValue;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            Primaryentitytypecode = primaryentitytypecode;
            this._modifiedbyValue = _modifiedbyValue;
            Datadescription = datadescription;
            Isdefault = isdefault;
            Userqueryvisualizationid = userqueryvisualizationid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            Name = name;
            Presentationdescription = presentationdescription;
            Charttype = charttype;
            this._createdbyValue = _createdbyValue;
            this._owninguserValue = _owninguserValue;
            Description = description;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedonbehalfby = modifiedonbehalfby;
            UserQueryVisualizationSyncErrors = userQueryVisualizationSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Owningteam = owningteam;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            Ownerid = ownerid;
            Webresourceid = webresourceid;
            Owninguser = owninguser;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_webresourceid_value")]
        public string _webresourceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datadescription")]
        public string Datadescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userqueryvisualizationid")]
        public string Userqueryvisualizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationdescription")]
        public string Presentationdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "charttype")]
        public int? Charttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserQueryVisualization_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UserQueryVisualizationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public MicrosoftDynamicsCRMwebresource Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
