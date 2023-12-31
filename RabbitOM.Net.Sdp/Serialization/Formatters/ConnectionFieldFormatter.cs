﻿using System;
using System.Linq;
using System.Text;

namespace RabbitOM.Net.Sdp.Serialization.Formatters
{
	/// <summary>
	/// Represent a class used to format and parse data
	/// </summary>
	public static class ConnectionFieldFormatter
	{
		/// <summary>
		/// Format to string the field
		/// </summary>
		/// <param name="field">the field</param>
		/// <returns>returns a string</returns>
		public static string Format(ConnectionField field)
		{
			if (field == null)
			{
				return string.Empty;
			}

			var builder = new StringBuilder();

			builder.AppendFormat(
				  "{0} {1} {2}"
				, SessionDescriptorDataConverter.ConvertToString(field.NetworkType)
				, SessionDescriptorDataConverter.ConvertToString(field.AddressType)
				, field.Address
				);


			if (field.TTL > 0)
			{
				builder.AppendFormat("/{0}", field.TTL);
			}

			return builder.ToString();
		}

		/// <summary>
		/// Try to parse
		/// </summary>
		/// <param name="value">the value</param>
		/// <param name="result">the field result</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public static bool TryParse(string value, out ConnectionField result)
		{
			result = null;

			if (string.IsNullOrWhiteSpace(value))
			{
				return false;
			}

			var tokens = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			if (tokens.Length < 3)
			{
				return false;
			}

			result = new ConnectionField()
			{
				NetworkType = SessionDescriptorDataConverter.ConvertToNetworkType(tokens.ElementAtOrDefault(0) ?? string.Empty),
				AddressType = SessionDescriptorDataConverter.ConvertToAddressType(tokens.ElementAtOrDefault(1) ?? string.Empty),
				Address     = tokens.ElementAtOrDefault(2),
				TTL         = SessionDescriptorDataConverter.ConvertToByteFromTTLFormat(tokens.ElementAtOrDefault(2)),
			};

			return true;
		}
	}
}
