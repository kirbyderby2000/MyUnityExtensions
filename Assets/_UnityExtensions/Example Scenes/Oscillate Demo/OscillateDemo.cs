using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

public class OscillateDemo : MonoBehaviour
{
    [SerializeField] Transform oscillateFrom;
    [SerializeField] Transform oscillateTo;
    [SerializeField] float secondsPerOscillation = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Oscillates this transform's position between two other position references
        // This example oscillates this transform's value using Time.time
        // The oscillated value goes from a to b at even numbers,
        // and from b to a at odd numbers
        // Full revolutions can be counted by dividing the oscillation value by 2
        transform.position = Oscillator.OscillateVector3(oscillateFrom.position, oscillateTo.position, Time.time / secondsPerOscillation);
    }
}
