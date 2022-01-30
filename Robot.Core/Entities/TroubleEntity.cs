using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Core.Entities
{
    public class TroubleEntity
    {
        public TroubleEntity()
        {

        }

        public Guid Id { get; set; }
        public string Code { get; set; }
    }
}
