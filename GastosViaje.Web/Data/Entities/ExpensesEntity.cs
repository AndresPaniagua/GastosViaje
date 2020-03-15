using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastosViaje.Web.Data.Entities
{
    public class ExpensesEntity
    {
        public int Id { get; set; }

        public string VoucherPath { get; set; }

        public double Cost { get; set; }

        public DateTime Date { get; set; }

        public ExpensesTypeEntity ExpensesType { get; set; }
    }
}
