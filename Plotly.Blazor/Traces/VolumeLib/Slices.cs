/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.VolumeLib
{
    /// <summary>
    ///     The Slices class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class Slices : IEquatable<Slices>
    {
        /// <summary>
        ///     Gets or sets the X.
        /// </summary>
        [JsonPropertyName(@"x")]
        public Plotly.Blazor.Traces.VolumeLib.SlicesLib.X X { get; set;} 

        /// <summary>
        ///     Gets or sets the Y.
        /// </summary>
        [JsonPropertyName(@"y")]
        public Plotly.Blazor.Traces.VolumeLib.SlicesLib.Y Y { get; set;} 

        /// <summary>
        ///     Gets or sets the Z.
        /// </summary>
        [JsonPropertyName(@"z")]
        public Plotly.Blazor.Traces.VolumeLib.SlicesLib.Z Z { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Slices other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Slices other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    X == other.X ||
                    X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    Y == other.Y ||
                    Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    Z == other.Z ||
                    Z != null &&
                    Z.Equals(other.Z)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Slices and the right Slices.
        /// </summary>
        /// <param name="left">Left Slices.</param>
        /// <param name="right">Right Slices.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Slices left, Slices right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Slices and the right Slices.
        /// </summary>
        /// <param name="left">Left Slices.</param>
        /// <param name="right">Right Slices.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Slices left, Slices right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Slices</returns>
        public Slices DeepClone()
        {
            return this.Copy();
        }
    }
}