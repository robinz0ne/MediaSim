using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Admin.DAL.Models.Base
{
    public class DBItem
    {
     
      // public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
