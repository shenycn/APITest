using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour
{
    public Transform cube;
    public int a= 8;
    public int b= 20;
    public float t= 0;
    
     
    // Start is called before the first frame update
    void Start()
    {
        cube.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float x= cube.position.x;
        float newx =Mathf.Lerp(x, 10, 0.1f);
        cube.position = new Vector3(newx, 0, 0);
        //print(Mathf.Lerp(a,b,t));
    }
}
/*
 * Mathf.Ler
 * 在 a 与 b 之间按 t 进行线性插值。
 * 参数 t 限制在范围 [0, 1] 内。
    当 t = 0 时，返回 a 。
    当 t = 1 时，返回 b 。
    当 t = 0.5 时，返回 a 和 b 的中点。
 */