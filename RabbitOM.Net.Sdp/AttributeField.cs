﻿using RabbitOM.Net.Sdp.Serialization.Formatters;
using System;

namespace RabbitOM.Net.Sdp
{
	/// <summary>
	/// Represent the sdp field
	/// </summary>
	public sealed class AttributeField : BaseField , ICopyable<AttributeField>
	{
		/// <summary>
		/// Represent the type name
		/// </summary>
		public const string TypeNameValue = "a";





		private string _name  = string.Empty;

		private string _value = string.Empty;





		/// <summary>
		/// Constructor
		/// </summary>
		public AttributeField()
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">the name</param>
		public AttributeField(string name) : this(name, string.Empty)
		{
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">the name</param>
		/// <param name="value">the value</param>
		public AttributeField(string name, string value)
		{
			Name  = name;
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
		/// Gets / Sets the name
		/// </summary>
		public string Name
		{
			get => _name;
			set => _name = SessionDescriptorDataConverter.Filter(value);
		}

		/// <summary>
		/// Gets / Sets the value
		/// </summary>
		public string Value
		{
			get => _value;
			set => _value = SessionDescriptorDataConverter.Filter(value);
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
			return !string.IsNullOrWhiteSpace(_name);
		}

		/// <summary>
		/// Make a copy
		/// </summary>
		/// <param name="field">the field</param>
		public void CopyFrom(AttributeField field)
		{
			if ( field == null )
			{
				return;
			}

			_name  = field._name;
			_value = field._value;
		}
		
		/// <summary>
		/// Format the field
		/// </summary>
		/// <returns>retuns a value</returns>
		public override string ToString()
		{
			return AttributeFieldFormatter.Format(this);
		}





		/// <summary>
		/// Parse
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>returns an instance</returns>
		/// <exception cref="ArgumentException"/>
		/// <exception cref="ArgumentNullException"/>
		/// <exception cref="FormatException"/>
		public static AttributeField Parse(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException(nameof(value));
			}

			return AttributeFieldFormatter.TryParse(value, out AttributeField result) ? result : throw new FormatException();
		}

		/// <summary>
		/// Try to parse
		/// </summary>
		/// <param name="value">the value</param>
		/// <param name="result">the field result</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public static bool TryParse(string value, out AttributeField result)
		{
			return AttributeFieldFormatter.TryParse(value, out result);
		}
	}
}
