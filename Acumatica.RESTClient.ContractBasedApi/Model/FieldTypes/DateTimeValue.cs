using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    /// <summary>
    /// Represents a date or date-and-time field of the Contract Based REST API.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <b>Receiving.</b> The server sends the value in its own time zone with the offset of that zone (for example
    /// <c>2018-07-17T12:30:00-04:00</c>). The client converts it to UTC, so <see cref="RestValueBase{TValue}.Value"/>
    /// always has <see cref="DateTimeKind.Utc"/> and its <c>Hour</c> and <c>Date</c> are UTC, not the wall-clock time of the site.
    /// The instant is the same, so a value that is received and sent back unchanged stays the same on the server.
    /// </para>
    /// <para>
    /// <b>Sending.</b> The <see cref="DateTime.Kind"/> of the value decides what is sent:
    /// <see cref="DateTimeKind.Utc"/> is sent with a <c>Z</c>, <see cref="DateTimeKind.Local"/> with the offset of this machine,
    /// and <see cref="DateTimeKind.Unspecified"/> without an offset. The server turns an offset into an instant and converts it
    /// to its own time zone, and it reads a value without an offset as its own local time. Use <see cref="DateTimeKind.Utc"/>
    /// (or <see cref="DateTimeKind.Local"/>) for an exact moment, and <see cref="DateTimeKind.Unspecified"/> for a time
    /// that is meant in the time zone of the site.
    /// </para>
    /// </remarks>
    [DataContract]
    public partial class DateTimeValue : RestValueBase<DateTime?>
    {
        public static implicit operator DateTime?(DateTimeValue value) => value.Value;
        public static implicit operator DateTimeValue(DateTime? value) => new DateTimeValue(value);

        /// <summary>Creates a field with the specified date and time.</summary>
        /// <param name="value">The date and time. Its <see cref="DateTime.Kind"/> decides what is sent to the server.</param>
        public DateTimeValue(DateTime? value = default)
        {
            this.Value = value;
        }
	}
}
