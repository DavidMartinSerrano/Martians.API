using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Responses
{
    public class CoordinatesResponse
    {
        public CoordinatesResponse()
        {

        }

        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// X coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Z coordinate.
        /// </summary>
        public int Z { get; set; }


    }
}
