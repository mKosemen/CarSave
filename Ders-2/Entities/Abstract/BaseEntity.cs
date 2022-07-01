using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSave.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        private DateTime _createTime = DateTime.Now;

        public DateTime CreateTime
        {
            get { return _createTime; }
        }

    }
}
