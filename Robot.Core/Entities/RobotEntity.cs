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
        public IList<TroubleEntity> Troubles { get; } = new List<TroubleEntity>();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        public RobotEntity(CoordinatesEntity coordinates, Orientation orientation)
        {
            Coordinates = coordinates;
            Orientation = orientation;
        }
    }
}
