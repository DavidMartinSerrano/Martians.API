using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Application.Responses
{
    public class TroubleResponse
    {
        public TroubleResponse()
        {

        }

        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Trouble code
        /// </summary>
        public string Code { get; set; }
    }
}
