using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector2.down);//0,-1
        print(Vector2.up);//0,1
        print(Vector2.right);//1,0
        print(Vector2.one);//1,1
        print(Vector2.zero);//00

        Vector2 a = new Vector2(2, 2);
        Vector2 b = new Vector2(3, 3);
        print(a.magnitude);//2.828427
        print(a.sqrMagnitude);//8
        print(b.magnitude);//4.24264
        print(b.sqrMagnitude);//18

        //返回值取得单位向量
        print(a.normalized);//0.71,0.71 
        print(b.normalized);//0.71,0.71

       
        print(a.x + "," + a.x);//2,2
        //吧自身单位化
        a.Normalize();
        print(a[0] + "," + a[1]);//2,2  \ 0.707,0.707

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//向量是结构体 是值类型 需要整体赋值