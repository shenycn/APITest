using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Time.deltaTime:" + Time.deltaTime);//0.02
        Debug.Log("Time.fixedDeltTime:" + Time.fixedDeltaTime);//0.02
        Debug.Log("Time.fixedTime:" + Time.fixedTime);//0
        Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);//2.0608248
        Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);//0
        Debug.Log("Time.time:" + Time.time);//0
        Debug.Log("Time.timeScale:" + Time.timeScale);//1
        Debug.Log("Time.timeSinceLeveLoad:" + Time.timeSinceLevelLoad);//0
        Debug.Log("Time.unscaledTime:" + Time.unscaledTime);//0
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time.deltaTime:"+Time.deltaTime);//不变
        Debug.Log("Time.fixedDeltTime:" + Time.fixedDeltaTime);//不变
        Debug.Log("Time.fixedTime:"+Time.fixedTime);//不变
        Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);//随着运行时间变化
        Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);//不变
        Debug.Log("Time.time:" + Time.time);//不变
        Debug.Log("Time.timeScale:" + Time.timeScale);//不变
        Debug.Log("Time.timeSinceLeveLoad:" + Time.timeSinceLevelLoad);//不变
        Debug.Log("Time.unscaledTime:" + Time.unscaledTime);//随着运行时间变化

        
    }
}
