using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public float speed;//速度
    public Transform Cube;
    public int runConut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.Translate(Vector3.forward * Time.deltaTime * speed);
        Time.timeScale = 3;
        float time1 = Time.realtimeSinceStartup;
        for(int i = 0; i < runConut; i++)
        {
            Method1();
        }
        float time2 = Time.realtimeSinceStartup;
        Debug.Log(time2 - time1);
    }
    void Method1()
    {
        int i = 1 + 2;
    }
    void Method2()
    {
        int j = 1 * 2;
    }
}
/*
 * Time.deltaTime可以控制物体的移动
 * realtimeSinceStartup可以做性能测试 
 */