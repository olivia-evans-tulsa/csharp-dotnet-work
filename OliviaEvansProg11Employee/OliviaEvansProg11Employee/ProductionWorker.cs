using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Project name:   OliviaEvansProg11Employee
 * Author : Olivia Evams
 * Date : 11/3/2024
 * Description : Initialize ProductionWorker class to store ShiftNum and HourlyRate properties
 */

namespace OliviaEvansProg11Employee
{
    class ProductionWorker : Employee // create extension of employee class
    {
        public int ShiftNum {  get; set; } // create .shiftnum
        public decimal HourlyRate { get; set; } // create .hourlyrate
    }
}
