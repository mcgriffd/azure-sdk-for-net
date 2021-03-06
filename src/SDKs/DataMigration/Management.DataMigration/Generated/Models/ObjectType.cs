// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ObjectType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ObjectType
    {
        [EnumMember(Value = "StoredProcedures")]
        StoredProcedures,
        [EnumMember(Value = "Table")]
        Table,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "View")]
        View,
        [EnumMember(Value = "Function")]
        Function
    }
    internal static class ObjectTypeEnumExtension
    {
        internal static string ToSerializedValue(this ObjectType? value)
        {
            return value == null ? null : ((ObjectType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ObjectType value)
        {
            switch( value )
            {
                case ObjectType.StoredProcedures:
                    return "StoredProcedures";
                case ObjectType.Table:
                    return "Table";
                case ObjectType.User:
                    return "User";
                case ObjectType.View:
                    return "View";
                case ObjectType.Function:
                    return "Function";
            }
            return null;
        }

        internal static ObjectType? ParseObjectType(this string value)
        {
            switch( value )
            {
                case "StoredProcedures":
                    return ObjectType.StoredProcedures;
                case "Table":
                    return ObjectType.Table;
                case "User":
                    return ObjectType.User;
                case "View":
                    return ObjectType.View;
                case "Function":
                    return ObjectType.Function;
            }
            return null;
        }
    }
}
