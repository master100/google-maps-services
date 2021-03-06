﻿namespace Velyo.Google.Services.Models
{
    public class Bounds
    {
        /// <summary>
        /// Gets or sets the north east.
        /// </summary>
        /// <value>The north east.</value>
        public LatLng NorthEast { get; set; }

        /// <summary>
        /// Gets or sets the south west.
        /// </summary>
        /// <value>The south west.</value>
        public LatLng SouthWest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{SouthWest}|{NorthEast}";
    }
}