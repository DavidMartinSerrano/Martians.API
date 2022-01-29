using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Core.Entities
{
    public class CoordinatesEntity
    {
        public CoordinatesEntity()
        {

        }
        public string Id { get; set; }

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
