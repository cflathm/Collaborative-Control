using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Wheel_Control : MonoBehaviour
{
    public Slider control;

    float maxSteerAngle = 30f;
    // Start is called before the first frame update
    void Update()
    {
        float steerScaler = -1 * (control.value - 0.5f) / 0.5f;
        float steerAngle = steerScaler * maxSteerAngle;
        Vector3 localAngle = transform.localEulerAngles;
        localAngle.z = steerAngle;
        transform.localEulerAngles = localAngle;
    }

}
