﻿using System;

namespace RabbitOM.Net.Rtsp
{
    /// <summary>
    /// Represent a message header
    /// </summary>
    public sealed class RTSPHeaderRequire : RTSPMessageHeader<string>
    {
        private string _value = string.Empty;



        /// <summary>
        /// Constructor
        /// </summary>
        public RTSPHeaderRequire()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">the value</param>
        public RTSPHeaderRequire( string value )
        {
            Value = value;
        }




        /// <summary>
        /// Gets the name
        /// </summary>
        public override string Name
        {
            get => RTSPHeaderNames.Require;
        }

        /// <summary>
        /// Gets / Sets the value
        /// </summary>
        public override string Value
        {
            get => _value;
            set => _value = RTSPDataFilter.Trim( value );
        }



        /// <summary>
        /// Validate
        /// </summary>
        /// <returns>returns true for a success, otherwise false</returns>
        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace( _value );
        }

        /// <summary>
        /// Returns an empty string
        /// </summary>
        /// <returns>returns a string value</returns>
        public override string ToString()
        {
            return _value;
        }

        /// <summary>
        /// Try to parse
        /// </summary>
        /// <param name="value">the header value</param>
        /// <param name="result">the output result</param>
        /// <returns>returns true for a success, otherwise false.</returns>
        public static bool TryParse( string value , out RTSPHeaderRequire result )
        {
            result = new RTSPHeaderRequire()
            {
                Value = value
            };

            return true;
        }
    }
}
