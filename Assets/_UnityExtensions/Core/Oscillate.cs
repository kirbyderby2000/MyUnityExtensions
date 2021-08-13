using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions
{

    public static class Oscillator
    {
        /// <summary>
        /// Returns an oscillated value between a and b. Oscillation values with an even floor oscillate from a to b, odd floors oscillate from b to a.
        /// </summary>
        /// <param name="a">oscillation from</param>
        /// <param name="b">oscillation to</param>
        /// <param name="oscillate">The oscillation value. Note: Numbers with an even floor oscillate from a to b. Numbers with an odd floor oscillate from b to a.</param>
        /// <returns></returns>
        public static float OscillateFloat(float a, float b, float oscillate)
        {
            return Mathf.Lerp(a, b,
                Mathf.Sin(((oscillate - 0.5f) * Mathf.PI)) / 2.0f + 0.5f);
        }

        /// <summary>
        /// Returns an oscillated Vector2 between two other Vector2s. Oscillation values with an even floor oscillate from a to b, odd floors oscillate from b to a.
        /// </summary>
        /// <param name="a">oscillation from</param>
        /// <param name="b">oscillation to</param>
        /// <param name="oscillate">The oscillation value. Note: Numbers with an even floor oscillate from a to b. Numbers with an odd floor oscillate from b to a.</param>
        /// <returns></returns>
        public static Vector2 OscillateVector2(Vector2 a, Vector2 b, float oscillate)
        {
            return new Vector2(OscillateFloat(a.x, b.x, oscillate),
                OscillateFloat(a.y, b.y, oscillate));
        }

        /// <summary>
        /// Returns an oscillated Vector3 between two other Vector3s. Oscillation values with an even floor oscillate from a to b, odd floors oscillate from b to a.
        /// </summary>
        /// <param name="a">oscillation from</param>
        /// <param name="b">oscillation to</param>
        /// <param name="oscillate">The oscillation value. Note: Numbers with an even floor oscillate from a to b. Numbers with an odd floor oscillate from b to a.</param>
        /// <returns></returns>
        public static Vector3 OscillateVector3(Vector3 a, Vector3 b, float oscillate)
        {
            return new Vector3(OscillateFloat(a.x, b.x, oscillate),
                OscillateFloat(a.y, b.y, oscillate),
                OscillateFloat(a.z, b.z, oscillate));
        }

    }

}
