using System;
using System.Globalization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    /// <summary>
    /// Serializes a <see cref="DateTime"/> as a bare "yyyy-MM-dd" date, matching the
    /// "format: date" that the endpoint schema declares for date-only fields, and reads
    /// back both bare dates and full timestamps (keeping only the date part).
    /// </summary>
    internal sealed class DateOnlyConverter : JsonConverter
    {
        public DateOnlyConverter()
        {
        }

        public override bool CanConvert(Type objectType)
            => objectType == typeof(DateTime) || objectType == typeof(DateTime?);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader));

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return null;

                // Newtonsoft pre-parses ISO-8601-looking strings into a date token before
                // the converter is reached, so this is the common case.
                case JsonToken.Date:
                    if (reader.Value is DateTime date)
                        return DateOnlyValue.Normalize(date);
                    if (reader.Value is DateTimeOffset offset)
                        return DateOnlyValue.Normalize(offset.DateTime);
                    break;

                case JsonToken.String:
                    string? text = (string?)reader.Value;
                    if (string.IsNullOrWhiteSpace(text))
                        return null;
                    return DateOnlyValue.Normalize(
                        DateTime.Parse(text, CultureInfo.InvariantCulture, DateTimeStyles.None));
            }

            throw new JsonSerializationException(
                $"Unexpected token {reader.TokenType} when parsing a date-only value.");
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteValue(((DateTime)value).ToString(DateOnlyValue.DateFormat, CultureInfo.InvariantCulture));
        }
    }
}