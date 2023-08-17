using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartmentEnum
    {
        HR,
        Financial,
        Shopping,
        Service,
        Janitorial
    }
}