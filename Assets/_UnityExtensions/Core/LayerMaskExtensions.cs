using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions
{

    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Returns whether or not this layer mask contains a given layer
        /// </summary>
        /// <param name="mask"></param>
        /// <param name="layerValue"></param>
        /// <returns></returns>
        public static bool ContainsLayer(this LayerMask mask, int layerValue)
        {
            return mask.value == (mask.value | (1 << layerValue));
        }
    }
    
}