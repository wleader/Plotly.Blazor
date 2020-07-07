/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib
{
    /// <summary>
    ///     The Center class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Center : IEquatable<Center>
    {
        /// <summary>
        ///     Sets the longitude of the center of the map (in degrees East).
        /// </summary>
        [JsonPropertyName(@"lon")]
        public decimal? Lon { get; set;} 

        /// <summary>
        ///     Sets the latitude of the center of the map (in degrees North).
        /// </summary>
        [JsonPropertyName(@"lat")]
        public decimal? Lat { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Center other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Center other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Lon == other.Lon ||
                    Lon != null &&
                    Lon.Equals(other.Lon)
                ) && 
                (
                    Lat == other.Lat ||
                    Lat != null &&
                    Lat.Equals(other.Lat)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Lon != null) hashCode = hashCode * 59 + Lon.GetHashCode();
                if (Lat != null) hashCode = hashCode * 59 + Lat.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Center and the right Center.
        /// </summary>
        /// <param name="left">Left Center.</param>
        /// <param name="right">Right Center.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Center left, Center right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Center and the right Center.
        /// </summary>
        /// <param name="left">Left Center.</param>
        /// <param name="right">Right Center.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Center left, Center right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Center</returns>
        public Center DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Center) formatter.Deserialize(ms);
        }
    }
}