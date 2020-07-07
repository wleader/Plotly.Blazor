/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor
{
    /// <summary>
    ///     The Animation class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Animation : IEquatable<Animation>
    {
        /// <summary>
        ///     Describes how a new animate call interacts with currently-running animations.
        ///     If <c>immediate</c>, current animations are interrupted and the new animation
        ///     is started. If <c>next</c>, the current frame is allowed to complete, after
        ///     which the new animation is started. If <c>afterall</c> all existing frames
        ///     are animated to completion before the new animation is started.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public Plotly.Blazor.AnimationLib.ModeEnum? Mode { get; set;} 

        /// <summary>
        ///     The direction in which to play the frames triggered by the animation call
        /// </summary>
        [JsonPropertyName(@"direction")]
        public Plotly.Blazor.AnimationLib.DirectionEnum? Direction { get; set;} 

        /// <summary>
        ///     Play frames starting at the current frame instead of the beginning.
        /// </summary>
        [JsonPropertyName(@"fromcurrent")]
        public bool? FromCurrent { get; set;} 

        /// <summary>
        ///     Gets or sets the Frame.
        /// </summary>
        [JsonPropertyName(@"frame")]
        public Plotly.Blazor.AnimationLib.Frame Frame { get; set;} 

        /// <summary>
        ///     Gets or sets the Transition.
        /// </summary>
        [JsonPropertyName(@"transition")]
        public Plotly.Blazor.AnimationLib.Transition Transition { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Animation other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Animation other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Mode == other.Mode ||
                    Mode != null &&
                    Mode.Equals(other.Mode)
                ) && 
                (
                    Direction == other.Direction ||
                    Direction != null &&
                    Direction.Equals(other.Direction)
                ) && 
                (
                    FromCurrent == other.FromCurrent ||
                    FromCurrent != null &&
                    FromCurrent.Equals(other.FromCurrent)
                ) && 
                (
                    Frame == other.Frame ||
                    Frame != null &&
                    Frame.Equals(other.Frame)
                ) && 
                (
                    Transition == other.Transition ||
                    Transition != null &&
                    Transition.Equals(other.Transition)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Mode != null) hashCode = hashCode * 59 + Mode.GetHashCode();
                if (Direction != null) hashCode = hashCode * 59 + Direction.GetHashCode();
                if (FromCurrent != null) hashCode = hashCode * 59 + FromCurrent.GetHashCode();
                if (Frame != null) hashCode = hashCode * 59 + Frame.GetHashCode();
                if (Transition != null) hashCode = hashCode * 59 + Transition.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Animation and the right Animation.
        /// </summary>
        /// <param name="left">Left Animation.</param>
        /// <param name="right">Right Animation.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Animation left, Animation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Animation and the right Animation.
        /// </summary>
        /// <param name="left">Left Animation.</param>
        /// <param name="right">Right Animation.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Animation left, Animation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Animation</returns>
        public Animation DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Animation) formatter.Deserialize(ms);
        }
    }
}