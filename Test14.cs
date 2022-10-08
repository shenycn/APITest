using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("left shift"))
        {
            //只会在一帧触发
            print("GetKeyDown");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //只会在一帧触发
            print("GetKeyDown");

        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //只会在一帧触发
            print("GetKeyUp");

        }
        if (Input.GetKey(KeyCode.Space))
        {
            //按键不抬起会一直触发
            print("GetKey");
        }
        //任意键盘和鼠标键都能触发
        if (Input.anyKeyDown)
        {
            print("anyKey");
        }


        //0：左键 1：右键 2：滚轮
        if (Input.GetMouseButton(0))
        {
            Debug.Log("preesed left click");
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("preesed right click");
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("preesed middle click");
        }
        
        //获取鼠标的位置 屏幕左下角为原点 像素为单位
        print(Input.mousePosition);
        //作用:通过鼠标触碰的位置来获取是否触发某种事件
        
    }
}
