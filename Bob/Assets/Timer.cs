using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        float minutes = (int)(Time.timeSinceLevelLoad/60f);
        float seconds = (int)(Time.timeSinceLevelLoad%60f);
        float milliseconds = (int)(Time.timeSinceLevelLoad * 6f);
        timer.text = minutes.ToString("00")+":"+seconds.ToString("00")+ ":" + milliseconds.ToString("00");
    }


}
