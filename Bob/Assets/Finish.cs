using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("finished");
        float minutes = (int)(Time.timeSinceLevelLoad/60f);
        float seconds = (int)(Time.timeSinceLevelLoad%60f);
        float milliseconds = (int)(Time.timeSinceLevelLoad * 6f);
        Debug.Log(minutes.ToString("00")+":"+seconds.ToString("00")+ ":" + milliseconds.ToString("00"));
    }
}
