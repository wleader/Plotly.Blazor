/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     The Selected class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Selected : IEquatable<Selected>
    {
        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.ViolinLib.SelectedLib.Marker Marker { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Selected other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Selected other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Marker == other.Marker ||
                    Marker != null &&
                    Marker.Equals(other.Marker)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Marker != null) hashCode = hashCode * 59 + Marker.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Selected and the right Selected.
        /// </summary>
        /// <param name="left">Left Selected.</param>
        /// <param name="right">Right Selected.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Selected left, Selected right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Selected and the right Selected.
        /// </summary>
        /// <param name="left">Left Selected.</param>
        /// <param name="right">Right Selected.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Selected left, Selected right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Selected</returns>
        public Selected DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Selected) formatter.Deserialize(ms);
        }
    }
}