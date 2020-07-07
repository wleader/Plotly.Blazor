/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.SceneLib
{
    /// <summary>
    ///     The Camera class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Camera : IEquatable<Camera>
    {
        /// <summary>
        ///     Sets the (x,y,z) components of the <c>up</c> camera vector. This vector
        ///     determines the up direction of this scene with respect to the page. The
        ///     default is &#39;{x: 0, y: 0, z: 1}&#39; which means that the z axis points
        ///     up.
        /// </summary>
        [JsonPropertyName(@"up")]
        public Plotly.Blazor.LayoutLib.SceneLib.CameraLib.Up Up { get; set;} 

        /// <summary>
        ///     Sets the (x,y,z) components of the <c>center</c> camera vector This vector
        ///     determines the translation (x,y,z) space about the center of this scene.
        ///     By default, there is no such translation.
        /// </summary>
        [JsonPropertyName(@"center")]
        public Plotly.Blazor.LayoutLib.SceneLib.CameraLib.Center Center { get; set;} 

        /// <summary>
        ///     Sets the (x,y,z) components of the <c>eye</c> camera vector. This vector
        ///     determines the view point about the origin of this scene.
        /// </summary>
        [JsonPropertyName(@"eye")]
        public Plotly.Blazor.LayoutLib.SceneLib.CameraLib.Eye Eye { get; set;} 

        /// <summary>
        ///     Gets or sets the Projection.
        /// </summary>
        [JsonPropertyName(@"projection")]
        public Plotly.Blazor.LayoutLib.SceneLib.CameraLib.Projection Projection { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Camera other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Camera other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Up == other.Up ||
                    Up != null &&
                    Up.Equals(other.Up)
                ) && 
                (
                    Center == other.Center ||
                    Center != null &&
                    Center.Equals(other.Center)
                ) && 
                (
                    Eye == other.Eye ||
                    Eye != null &&
                    Eye.Equals(other.Eye)
                ) && 
                (
                    Projection == other.Projection ||
                    Projection != null &&
                    Projection.Equals(other.Projection)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Up != null) hashCode = hashCode * 59 + Up.GetHashCode();
                if (Center != null) hashCode = hashCode * 59 + Center.GetHashCode();
                if (Eye != null) hashCode = hashCode * 59 + Eye.GetHashCode();
                if (Projection != null) hashCode = hashCode * 59 + Projection.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Camera and the right Camera.
        /// </summary>
        /// <param name="left">Left Camera.</param>
        /// <param name="right">Right Camera.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Camera left, Camera right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Camera and the right Camera.
        /// </summary>
        /// <param name="left">Left Camera.</param>
        /// <param name="right">Right Camera.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Camera left, Camera right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Camera</returns>
        public Camera DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;
            return (Camera) formatter.Deserialize(ms);
        }
    }
}