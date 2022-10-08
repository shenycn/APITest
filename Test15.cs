using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    public Transform cube;
  //  public speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonDown("Fire1"))
        {
            //一个button可以对应多个按键 都能触发
            //左ctrl 和鼠标左键都能触发
            print("Fire1");
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            print("Horizontal");
        }
        Input.GetAxis("Horizontal");
        print(Input.GetAxis("Horizontal"));//取值0~-1
        //使物体移动 有重力导致的效果
        cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")*10);
        //使物体移动 无重力导致的效果
        //cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxisRaw("Horizontal")*10);
    }
}
//bottom就是虚拟按键
