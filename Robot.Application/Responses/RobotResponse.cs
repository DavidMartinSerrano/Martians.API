using Robot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Responses
{
    public class RobotResponse
    {
        public RobotResponse()
        {
            Troubles = new List<TroubleResponse>();

        }

        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }


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
        public List<TroubleResponse> Troubles { get; set; }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public RobotResponse(CoordinatesResponse coordinates, Orientation orientation)
        {
            Coordinates = coordinates;
            Orientation = orientation;
            Troubles = new List<TroubleResponse>();
        }


    }
}
