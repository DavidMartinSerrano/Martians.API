using Robot.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Core.Entities
{
    public class RobotEntity
    {
        public RobotEntity()
        {
            Troubles = new List<TroubleEntity>();
        }

        public Guid Id { get; set; }

        /// <summary>
        /// Current coordinates.
        /// </summary>
        public CoordinatesEntity Coordinates { get; set; }

        /// <summary>
        /// Current orientation.
        /// </summary>
        public Orientation Orientation { get; set; }

        /// <summary>
        /// Reported troubles.
        /// </summary>
        public List<TroubleEntity> Troubles { get; set; }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public RobotEntity(CoordinatesEntity coordinates, Orientation orientation)
        {
            Coordinates = coordinates;
            Orientation = orientation;
            Troubles = new List<TroubleEntity>();
        }
    }
}
