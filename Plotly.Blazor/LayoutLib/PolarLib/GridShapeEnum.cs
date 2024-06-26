/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.PolarLib
{
    /// <summary>
    ///     Determines if the radial axis grid lines and angular axis line are drawn
    ///     as <c>circular</c> sectors or as <c>linear</c> (polygon) sectors. Has an
    ///     effect only when the angular axis has <c>type</c> <c>category</c>. Note
    ///     that <c>radialaxis.angle</c> is snapped to the angle of the closest vertex
    ///     when <c>gridshape</c> is <c>circular</c> (so that radial axis scale is the
    ///     same as the data scale).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum GridShapeEnum
    {
        [EnumMember(Value=@"circular")]
        Circular = 0,
        [EnumMember(Value=@"linear")]
        Linear
    }
}