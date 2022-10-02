using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("Attack", 3);//3秒后调用
        InvokeRepeating("Attack", 4, 2); //意思是四秒之后调用一次 之后每间隔两秒调用一次
        CancelInvoke("Attack");
    }
    private void Update()
    {
        bool res = IsInvoking("Attack");//判断是否处于等待状态
        //  print(res);//此处3秒前是true 3秒后是FALSE
        print(res);//每间隔两秒 返回一次TRUE
    }
    // Update is called once per frame
    void Attack()
    {
        print("攻击目标");
    }
}
/*
 * CancelInvoke();当它指定参数时 取消方法名的调用
 * 不指定参数 就是吧所有的方法名取消
 */