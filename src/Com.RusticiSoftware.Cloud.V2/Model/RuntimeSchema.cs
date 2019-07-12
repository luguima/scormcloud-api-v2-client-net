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

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// RuntimeSchema
    /// </summary>
    [DataContract]
    public partial class RuntimeSchema :  IEquatable<RuntimeSchema>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RuntimeSuccessStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuntimeSuccessStatusEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum PASSED for "PASSED"
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSED,
            
            /// <summary>
            /// Enum FAILED for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED
        }

        /// <summary>
        /// Gets or Sets RuntimeSuccessStatus
        /// </summary>
        [DataMember(Name="runtimeSuccessStatus", EmitDefaultValue=false)]
        public RuntimeSuccessStatusEnum? RuntimeSuccessStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeSchema" /> class.
        /// </summary>
        /// <param name="CompletionStatus">CompletionStatus.</param>
        /// <param name="Credit">Credit.</param>
        /// <param name="Entry">Entry.</param>
        /// <param name="Exit">Exit.</param>
        /// <param name="LearnerPreference">LearnerPreference.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Mode">Mode.</param>
        /// <param name="ProgressMeasure">ProgressMeasure.</param>
        /// <param name="ScoreScaled">ScoreScaled.</param>
        /// <param name="ScoreRaw">ScoreRaw.</param>
        /// <param name="ScoreMin">ScoreMin.</param>
        /// <param name="ScoreMax">ScoreMax.</param>
        /// <param name="TotalTime">TotalTime.</param>
        /// <param name="TimeTracked">TimeTracked.</param>
        /// <param name="RuntimeSuccessStatus">RuntimeSuccessStatus (default to RuntimeSuccessStatusEnum.UNKNOWN).</param>
        /// <param name="SuspendData">SuspendData.</param>
        /// <param name="LearnerComments">LearnerComments.</param>
        /// <param name="LmsComments">LmsComments.</param>
        /// <param name="RuntimeInteractions">RuntimeInteractions.</param>
        /// <param name="RuntimeObjectives">RuntimeObjectives.</param>
        public RuntimeSchema(string CompletionStatus = default(string), string Credit = default(string), string Entry = default(string), string Exit = default(string), LearnerPreferenceSchema LearnerPreference = default(LearnerPreferenceSchema), string Location = default(string), string Mode = default(string), string ProgressMeasure = default(string), string ScoreScaled = default(string), string ScoreRaw = default(string), string ScoreMin = default(string), string ScoreMax = default(string), string TotalTime = default(string), string TimeTracked = default(string), RuntimeSuccessStatusEnum? RuntimeSuccessStatus = RuntimeSuccessStatusEnum.UNKNOWN, string SuspendData = default(string), List<CommentSchema> LearnerComments = default(List<CommentSchema>), List<CommentSchema> LmsComments = default(List<CommentSchema>), List<RuntimeInteractionSchema> RuntimeInteractions = default(List<RuntimeInteractionSchema>), List<RuntimeObjectiveSchema> RuntimeObjectives = default(List<RuntimeObjectiveSchema>))
        {
            this.CompletionStatus = CompletionStatus;
            this.Credit = Credit;
            this.Entry = Entry;
            this.Exit = Exit;
            this.LearnerPreference = LearnerPreference;
            this.Location = Location;
            this.Mode = Mode;
            this.ProgressMeasure = ProgressMeasure;
            this.ScoreScaled = ScoreScaled;
            this.ScoreRaw = ScoreRaw;
            this.ScoreMin = ScoreMin;
            this.ScoreMax = ScoreMax;
            this.TotalTime = TotalTime;
            this.TimeTracked = TimeTracked;
            // use default value if no "RuntimeSuccessStatus" provided
            if (RuntimeSuccessStatus == null)
            {
                this.RuntimeSuccessStatus = RuntimeSuccessStatusEnum.UNKNOWN;
            }
            else
            {
                this.RuntimeSuccessStatus = RuntimeSuccessStatus;
            }
            this.SuspendData = SuspendData;
            this.LearnerComments = LearnerComments;
            this.LmsComments = LmsComments;
            this.RuntimeInteractions = RuntimeInteractions;
            this.RuntimeObjectives = RuntimeObjectives;
        }
        
        /// <summary>
        /// Gets or Sets CompletionStatus
        /// </summary>
        [DataMember(Name="completionStatus", EmitDefaultValue=false)]
        public string CompletionStatus { get; set; }
        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name="credit", EmitDefaultValue=false)]
        public string Credit { get; set; }
        /// <summary>
        /// Gets or Sets Entry
        /// </summary>
        [DataMember(Name="entry", EmitDefaultValue=false)]
        public string Entry { get; set; }
        /// <summary>
        /// Gets or Sets Exit
        /// </summary>
        [DataMember(Name="exit", EmitDefaultValue=false)]
        public string Exit { get; set; }
        /// <summary>
        /// Gets or Sets LearnerPreference
        /// </summary>
        [DataMember(Name="learnerPreference", EmitDefaultValue=false)]
        public LearnerPreferenceSchema LearnerPreference { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
        /// <summary>
        /// Gets or Sets ProgressMeasure
        /// </summary>
        [DataMember(Name="progressMeasure", EmitDefaultValue=false)]
        public string ProgressMeasure { get; set; }
        /// <summary>
        /// Gets or Sets ScoreScaled
        /// </summary>
        [DataMember(Name="scoreScaled", EmitDefaultValue=false)]
        public string ScoreScaled { get; set; }
        /// <summary>
        /// Gets or Sets ScoreRaw
        /// </summary>
        [DataMember(Name="scoreRaw", EmitDefaultValue=false)]
        public string ScoreRaw { get; set; }
        /// <summary>
        /// Gets or Sets ScoreMin
        /// </summary>
        [DataMember(Name="scoreMin", EmitDefaultValue=false)]
        public string ScoreMin { get; set; }
        /// <summary>
        /// Gets or Sets ScoreMax
        /// </summary>
        [DataMember(Name="scoreMax", EmitDefaultValue=false)]
        public string ScoreMax { get; set; }
        /// <summary>
        /// Gets or Sets TotalTime
        /// </summary>
        [DataMember(Name="totalTime", EmitDefaultValue=false)]
        public string TotalTime { get; set; }
        /// <summary>
        /// Gets or Sets TimeTracked
        /// </summary>
        [DataMember(Name="timeTracked", EmitDefaultValue=false)]
        public string TimeTracked { get; set; }
        /// <summary>
        /// Gets or Sets SuspendData
        /// </summary>
        [DataMember(Name="suspendData", EmitDefaultValue=false)]
        public string SuspendData { get; set; }
        /// <summary>
        /// Gets or Sets LearnerComments
        /// </summary>
        [DataMember(Name="learnerComments", EmitDefaultValue=false)]
        public List<CommentSchema> LearnerComments { get; set; }
        /// <summary>
        /// Gets or Sets LmsComments
        /// </summary>
        [DataMember(Name="lmsComments", EmitDefaultValue=false)]
        public List<CommentSchema> LmsComments { get; set; }
        /// <summary>
        /// Gets or Sets RuntimeInteractions
        /// </summary>
        [DataMember(Name="runtimeInteractions", EmitDefaultValue=false)]
        public List<RuntimeInteractionSchema> RuntimeInteractions { get; set; }
        /// <summary>
        /// Gets or Sets RuntimeObjectives
        /// </summary>
        [DataMember(Name="runtimeObjectives", EmitDefaultValue=false)]
        public List<RuntimeObjectiveSchema> RuntimeObjectives { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuntimeSchema {\n");
            sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Entry: ").Append(Entry).Append("\n");
            sb.Append("  Exit: ").Append(Exit).Append("\n");
            sb.Append("  LearnerPreference: ").Append(LearnerPreference).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  ProgressMeasure: ").Append(ProgressMeasure).Append("\n");
            sb.Append("  ScoreScaled: ").Append(ScoreScaled).Append("\n");
            sb.Append("  ScoreRaw: ").Append(ScoreRaw).Append("\n");
            sb.Append("  ScoreMin: ").Append(ScoreMin).Append("\n");
            sb.Append("  ScoreMax: ").Append(ScoreMax).Append("\n");
            sb.Append("  TotalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  TimeTracked: ").Append(TimeTracked).Append("\n");
            sb.Append("  RuntimeSuccessStatus: ").Append(RuntimeSuccessStatus).Append("\n");
            sb.Append("  SuspendData: ").Append(SuspendData).Append("\n");
            sb.Append("  LearnerComments: ").Append(LearnerComments).Append("\n");
            sb.Append("  LmsComments: ").Append(LmsComments).Append("\n");
            sb.Append("  RuntimeInteractions: ").Append(RuntimeInteractions).Append("\n");
            sb.Append("  RuntimeObjectives: ").Append(RuntimeObjectives).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RuntimeSchema);
        }

        /// <summary>
        /// Returns true if RuntimeSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of RuntimeSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuntimeSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompletionStatus == other.CompletionStatus ||
                    this.CompletionStatus != null &&
                    this.CompletionStatus.Equals(other.CompletionStatus)
                ) && 
                (
                    this.Credit == other.Credit ||
                    this.Credit != null &&
                    this.Credit.Equals(other.Credit)
                ) && 
                (
                    this.Entry == other.Entry ||
                    this.Entry != null &&
                    this.Entry.Equals(other.Entry)
                ) && 
                (
                    this.Exit == other.Exit ||
                    this.Exit != null &&
                    this.Exit.Equals(other.Exit)
                ) && 
                (
                    this.LearnerPreference == other.LearnerPreference ||
                    this.LearnerPreference != null &&
                    this.LearnerPreference.Equals(other.LearnerPreference)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.ProgressMeasure == other.ProgressMeasure ||
                    this.ProgressMeasure != null &&
                    this.ProgressMeasure.Equals(other.ProgressMeasure)
                ) && 
                (
                    this.ScoreScaled == other.ScoreScaled ||
                    this.ScoreScaled != null &&
                    this.ScoreScaled.Equals(other.ScoreScaled)
                ) && 
                (
                    this.ScoreRaw == other.ScoreRaw ||
                    this.ScoreRaw != null &&
                    this.ScoreRaw.Equals(other.ScoreRaw)
                ) && 
                (
                    this.ScoreMin == other.ScoreMin ||
                    this.ScoreMin != null &&
                    this.ScoreMin.Equals(other.ScoreMin)
                ) && 
                (
                    this.ScoreMax == other.ScoreMax ||
                    this.ScoreMax != null &&
                    this.ScoreMax.Equals(other.ScoreMax)
                ) && 
                (
                    this.TotalTime == other.TotalTime ||
                    this.TotalTime != null &&
                    this.TotalTime.Equals(other.TotalTime)
                ) && 
                (
                    this.TimeTracked == other.TimeTracked ||
                    this.TimeTracked != null &&
                    this.TimeTracked.Equals(other.TimeTracked)
                ) && 
                (
                    this.RuntimeSuccessStatus == other.RuntimeSuccessStatus ||
                    this.RuntimeSuccessStatus != null &&
                    this.RuntimeSuccessStatus.Equals(other.RuntimeSuccessStatus)
                ) && 
                (
                    this.SuspendData == other.SuspendData ||
                    this.SuspendData != null &&
                    this.SuspendData.Equals(other.SuspendData)
                ) && 
                (
                    this.LearnerComments == other.LearnerComments ||
                    this.LearnerComments != null &&
                    this.LearnerComments.SequenceEqual(other.LearnerComments)
                ) && 
                (
                    this.LmsComments == other.LmsComments ||
                    this.LmsComments != null &&
                    this.LmsComments.SequenceEqual(other.LmsComments)
                ) && 
                (
                    this.RuntimeInteractions == other.RuntimeInteractions ||
                    this.RuntimeInteractions != null &&
                    this.RuntimeInteractions.SequenceEqual(other.RuntimeInteractions)
                ) && 
                (
                    this.RuntimeObjectives == other.RuntimeObjectives ||
                    this.RuntimeObjectives != null &&
                    this.RuntimeObjectives.SequenceEqual(other.RuntimeObjectives)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CompletionStatus != null)
                    hash = hash * 59 + this.CompletionStatus.GetHashCode();
                if (this.Credit != null)
                    hash = hash * 59 + this.Credit.GetHashCode();
                if (this.Entry != null)
                    hash = hash * 59 + this.Entry.GetHashCode();
                if (this.Exit != null)
                    hash = hash * 59 + this.Exit.GetHashCode();
                if (this.LearnerPreference != null)
                    hash = hash * 59 + this.LearnerPreference.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.ProgressMeasure != null)
                    hash = hash * 59 + this.ProgressMeasure.GetHashCode();
                if (this.ScoreScaled != null)
                    hash = hash * 59 + this.ScoreScaled.GetHashCode();
                if (this.ScoreRaw != null)
                    hash = hash * 59 + this.ScoreRaw.GetHashCode();
                if (this.ScoreMin != null)
                    hash = hash * 59 + this.ScoreMin.GetHashCode();
                if (this.ScoreMax != null)
                    hash = hash * 59 + this.ScoreMax.GetHashCode();
                if (this.TotalTime != null)
                    hash = hash * 59 + this.TotalTime.GetHashCode();
                if (this.TimeTracked != null)
                    hash = hash * 59 + this.TimeTracked.GetHashCode();
                if (this.RuntimeSuccessStatus != null)
                    hash = hash * 59 + this.RuntimeSuccessStatus.GetHashCode();
                if (this.SuspendData != null)
                    hash = hash * 59 + this.SuspendData.GetHashCode();
                if (this.LearnerComments != null)
                    hash = hash * 59 + this.LearnerComments.GetHashCode();
                if (this.LmsComments != null)
                    hash = hash * 59 + this.LmsComments.GetHashCode();
                if (this.RuntimeInteractions != null)
                    hash = hash * 59 + this.RuntimeInteractions.GetHashCode();
                if (this.RuntimeObjectives != null)
                    hash = hash * 59 + this.RuntimeObjectives.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
