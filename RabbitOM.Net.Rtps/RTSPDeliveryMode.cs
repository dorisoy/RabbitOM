﻿using System;

namespace RabbitOM.Net.Rtsp
{
    /// <summary>
    /// Represent the diffusion mode type
    /// </summary>
    public enum RTSPDeliveryMode
    {
        /// <summary>
        /// Unicast Udp
        /// </summary>
        Udp = 0,

        /// <summary>
        /// Unicast Tcp which represent the interleaved mode
        /// </summary>
        Tcp,

        /// <summary>
        /// Multicast
        /// </summary>
        Multicast,
    }
}
