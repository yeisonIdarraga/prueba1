using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace prueba_1.function.entitis
{
    public class todoentity :TableEntity // hereda la propiedades de azure storege table

    {
        public int DateTimecreatedTime { get; set; }
        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
