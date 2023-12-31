/*
 * Paperless Rest Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApiuiSettingsSettingsUpdateChecking : IEquatable<ApiuiSettingsSettingsUpdateChecking>
    { 
        /// <summary>
        /// Gets or Sets BackendSetting
        /// </summary>
        [Required]

        [DataMember(Name="backend_setting")]
        public string BackendSetting { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [Required]

        [DataMember(Name="enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiuiSettingsSettingsUpdateChecking {\n");
            sb.Append("  BackendSetting: ").Append(BackendSetting).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ApiuiSettingsSettingsUpdateChecking)obj);
        }

        /// <summary>
        /// Returns true if ApiuiSettingsSettingsUpdateChecking instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiuiSettingsSettingsUpdateChecking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiuiSettingsSettingsUpdateChecking other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BackendSetting == other.BackendSetting ||
                    BackendSetting != null &&
                    BackendSetting.Equals(other.BackendSetting)
                ) && 
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (BackendSetting != null)
                    hashCode = hashCode * 59 + BackendSetting.GetHashCode();
                    if (Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApiuiSettingsSettingsUpdateChecking left, ApiuiSettingsSettingsUpdateChecking right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApiuiSettingsSettingsUpdateChecking left, ApiuiSettingsSettingsUpdateChecking right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
