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
        Debug.Log("Time.deltaTime:"+Time.deltaTime);//����
        Debug.Log("Time.fixedDeltTime:" + Time.fixedDeltaTime);//����
        Debug.Log("Time.fixedTime:"+Time.fixedTime);//����
        Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);//��������ʱ��仯
        Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);//����
        Debug.Log("Time.time:" + Time.time);//����
        Debug.Log("Time.timeScale:" + Time.timeScale);//����
        Debug.Log("Time.timeSinceLeveLoad:" + Time.timeSinceLevelLoad);//����
        Debug.Log("Time.unscaledTime:" + Time.unscaledTime);//��������ʱ��仯

        
    }
}
