using System.Text.Json;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Extensions
{
    public class JsonBoolenConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (bool.TryParse(stringValue, out bool result))
                {
                    return result;
                }
            }
            return false;
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value);
        }
    }
}
