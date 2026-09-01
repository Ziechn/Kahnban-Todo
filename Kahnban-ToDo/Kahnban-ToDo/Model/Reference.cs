using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Kahnban_ToDo
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(TextReference), "text")]
    [JsonDerivedType(typeof(FileReference), "file")]
    public class Reference
    {
        public long Id { get; set; }
        public string Title { get; set; } = "";
    }
}
