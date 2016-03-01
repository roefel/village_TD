using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Village_TD
{
    class ResourceBuilding:Building
    {
        
        public static readonly int[] numLevelPerSec = { 5, 15, 40, 100, 250 };//array to define number of resources gained per second

        public int NumPerSec
        {
            get
            {
                return numLevelPerSec[Level - 1];
            }
        }
    }
}
