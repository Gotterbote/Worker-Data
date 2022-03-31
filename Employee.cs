using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Data
{
    class Employee
    {
        // fields
        int _employeeNumber;
        string _employeeName;
        
        public int employeeNumber
        {
            get
            {
                return _employeeNumber;
            }
            set
            {
                _employeeNumber = value;
            }
        }// end employeeNumber accessor

        public string employeeName
        {
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }// emd emplyeeName accessor
    }//end constructor
}
