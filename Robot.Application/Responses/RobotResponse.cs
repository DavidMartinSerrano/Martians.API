using Robot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Responses
{
    public class RobotResponse
    {

        /// <summary>
        /// Current coordinates.
        /// </summary>
        public CoordinatesResponse Coordinates { get; set; }

        /// <summary>
        /// Current orientation.
        /// </summary>
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Reported troubles.
        /// </summary>
        public IList<TroubleResponse> Troubles { get; } = new List<TroubleResponse>();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public RobotResponse(CoordinatesResponse coordinates, Orientation orientation)
        {
            Coordinates = coordinates;
            Orientation = orientation;
        }


    }
}
