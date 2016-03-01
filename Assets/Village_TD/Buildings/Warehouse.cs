using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Village_TD
{
    class Warehouse:Building
    {

        public static readonly int[] maxLevelStorage = { 300, 2400, 15000 };//array for defining max warehouse capacity
        

        public int MaxStorage
        {
            get
            {
                return maxLevelStorage[Level - 1];
            }

        }
    }
}
