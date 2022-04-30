﻿using RabbitOM.Net.Sdp.Serialization.Formatters;
using System;
using System.Globalization;

namespace RabbitOM.Net.Sdp
{
	/// <summary>
	/// Represent the sdp field
	/// </summary>
	public sealed class PhoneField : BaseField<PhoneField>, IFormattable
	{
		/// <summary>
		/// Represent the type name
		/// </summary>
		public const string TypeNameValue = "p";




		private string _value = string.Empty;




		/// <summary>
		/// Constructor
		/// </summary>
		public PhoneField()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="value">the value</param>
		public PhoneField(string value)
		{
			Value = value;
		}




		/// <summary>
		/// Gets the type name
		/// </summary>
		public override string TypeName
		{
			get => TypeNameValue;
		}

		/// <summary>
		/// Gets / Sets the value
		/// </summary>
		public string Value
		{
			get => _value;
			set => _value = SessionDescriptorDataConverter.Trim(value);
		}




		/// <summary>
		/// Validate
		/// </summary>
		/// <exception cref="Exception"/>
		public override void Validate()
		{
			if (!TryValidate())
			{
				throw new Exception("Validation failed");
			}
		}
		
		/// <summary>
		 /// Validate
		 /// </summary>
		 /// <returns>returns true for a success, otherwise false</returns>
		public override bool TryValidate()
		{
			return !string.IsNullOrWhiteSpace(_value);
		}

		/// <summary>
		/// Make a copy
		/// </summary>
		/// <param name="field">the field</param>
		public override void CopyFrom(PhoneField field)
		{
			if ( field == null )
			{
				return;
			}

			_value = field._value;
		}

		/// <summary>
		/// Format the field
		/// </summary>
		/// <returns>retuns a value</returns>
		public override string ToString()
		{
			return ToString(null);
		}

		/// <summary>
		/// Format the field
		/// </summary>
		/// <param name="format">the format</param>
		/// <returns>retuns a value</returns>
		public string ToString(string format)
		{
			return ToString(format, CultureInfo.CurrentCulture);
		}

		/// <summary>
		/// Format the field
		/// </summary>
		/// <param name="format">the format</param>
		/// <param name="formatProvider">the format provider</param>
		/// <returns>retuns a value</returns>
		/// <exception cref="FormatException"/>
		public string ToString(string format, IFormatProvider formatProvider)
		{
			if ( string.IsNullOrEmpty( format ) )
			{
				return PhoneFieldFormatter.Format(formatProvider, this);
			}

			if (format.Equals("sdp", StringComparison.OrdinalIgnoreCase))
			{
				return PhoneFieldFormatter.Format(formatProvider, this);
			}

			throw new FormatException();
		}




		/// <summary>
		/// Parse
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>returns an instance</returns>
		/// <exception cref="ArgumentException"/>
		/// <exception cref="ArgumentNullException"/>
		/// <exception cref="FormatException"/>
		public static PhoneField Parse(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException(nameof(value));
			}

			return PhoneFieldFormatter.TryFrom(value, out PhoneField result) ? result : throw new FormatException();
		}

		/// <summary>
		/// Try to parse
		/// </summary>
		/// <param name="value">the value</param>
		/// <param name="result">the field result</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public static bool TryParse(string value, out PhoneField result)
		{
			return PhoneFieldFormatter.TryFrom(value, out result);
		}
	}
}
