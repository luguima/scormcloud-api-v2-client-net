/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Com.RusticiSoftware.Cloud.V2.Client.SwaggerDateConverter;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// YAML 2.0 does not support oneOf so this is used when object can be an Agent or a Group.
    /// </summary>
    [DataContract]
    public partial class XapiAgentGroup :  IEquatable<XapiAgentGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines ObjectType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectTypeEnum
        {
            
            /// <summary>
            /// Enum Agent for value: Agent
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent = 1,
            
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 2
        }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiAgentGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XapiAgentGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiAgentGroup" /> class.
        /// </summary>
        /// <param name="objectType">objectType (required).</param>
        /// <param name="name">name.</param>
        /// <param name="mbox">mbox.</param>
        /// <param name="mboxSha1sum">mboxSha1sum.</param>
        /// <param name="openid">openid.</param>
        /// <param name="account">account.</param>
        /// <param name="member">member.</param>
        public XapiAgentGroup(ObjectTypeEnum objectType = default(ObjectTypeEnum), string name = default(string), string mbox = default(string), string mboxSha1sum = default(string), string openid = default(string), XapiAccount account = default(XapiAccount), List<XapiAgentGroup> member = default(List<XapiAgentGroup>))
        {
            // to ensure "objectType" is required (not null)
            if (objectType == null)
            {
                throw new InvalidDataException("objectType is a required property for XapiAgentGroup and cannot be null");
            }
            else
            {
                this.ObjectType = objectType;
            }
            this.Name = name;
            this.Mbox = mbox;
            this.MboxSha1sum = mboxSha1sum;
            this.Openid = openid;
            this.Account = account;
            this.Member = member;
        }
        

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Mbox
        /// </summary>
        [DataMember(Name="mbox", EmitDefaultValue=false)]
        public string Mbox { get; set; }

        /// <summary>
        /// Gets or Sets MboxSha1sum
        /// </summary>
        [DataMember(Name="mbox_sha1sum", EmitDefaultValue=false)]
        public string MboxSha1sum { get; set; }

        /// <summary>
        /// Gets or Sets Openid
        /// </summary>
        [DataMember(Name="openid", EmitDefaultValue=false)]
        public string Openid { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public XapiAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public List<XapiAgentGroup> Member { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiAgentGroup {\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mbox: ").Append(Mbox).Append("\n");
            sb.Append("  MboxSha1sum: ").Append(MboxSha1sum).Append("\n");
            sb.Append("  Openid: ").Append(Openid).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as XapiAgentGroup);
        }

        /// <summary>
        /// Returns true if XapiAgentGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of XapiAgentGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiAgentGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mbox == input.Mbox ||
                    (this.Mbox != null &&
                    this.Mbox.Equals(input.Mbox))
                ) && 
                (
                    this.MboxSha1sum == input.MboxSha1sum ||
                    (this.MboxSha1sum != null &&
                    this.MboxSha1sum.Equals(input.MboxSha1sum))
                ) && 
                (
                    this.Openid == input.Openid ||
                    (this.Openid != null &&
                    this.Openid.Equals(input.Openid))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Member == input.Member ||
                    this.Member != null &&
                    this.Member.SequenceEqual(input.Member)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mbox != null)
                    hashCode = hashCode * 59 + this.Mbox.GetHashCode();
                if (this.MboxSha1sum != null)
                    hashCode = hashCode * 59 + this.MboxSha1sum.GetHashCode();
                if (this.Openid != null)
                    hashCode = hashCode * 59 + this.Openid.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
