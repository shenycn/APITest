using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    public cube cube1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.isActiveAndEnabled);//判断自身是否是激活的
        Debug.Log(this.enabled);//判断自身是否是激活的
        enabled = false;//禁用
        Debug.Log(name);
        Debug.Log(tag);
        Debug.Log(gameObject);
        Debug.Log(transform);

        print("hhhhh");

        Debug.Log(cube1.isActiveAndEnabled);//判断自身是否是激活的
        Debug.Log(cube1.enabled);//判断自身是否是激活的
        cube1.enabled = false;

        Debug.Log(cube1.name);
        Debug.Log(cube1.tag);
        Debug.Log(cube1.gameObject);
        Debug.Log(cube1.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*
 * [ExecuteInEditMode]是一种特性 
 * 作用是：在编辑模式下也能运行，一般用于特殊的初始化
 * 用法 直接加到某个类上
 */