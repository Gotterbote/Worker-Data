using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Data

{
    class ProductionWorker : Employee
    {
        // fields
        int _shiftNumber;
        decimal _hourlyWage;

        public int shiftNumber
        {
            get
            {
                return _shiftNumber;
            }
            set
            {
                _shiftNumber = value;
            }
        }// end shiftNumber accessor

        public decimal hourlyWage
        {
            get
            {
                return _hourlyWage;
            }
            set
            {
                _hourlyWage = value;
            }
        }// end hourlyWage accessor

    } // end constructor
}
