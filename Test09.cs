        using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test09 : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
    //    print("hhhhhh");
     //  StartCoroutine( ChangeColor());
     //   print("-------");

    }

    // Update is called once per frame
    private IEnumerator ie;
    void Update()
    {
        //StartCoroutine、StopCoroutine要传递相同类型的值
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ie = Fade2();
            StartCoroutine(ie);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine(ie);
        }
    }
    //实现黑白颜色的渐变
    IEnumerator Fade1()
    {
        for (float i = 0; i <= 1; i += 0.1f)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(i, i, i);
            yield return new WaitForSeconds(0.1f);//0.1s的视觉效果
        }
    }
    IEnumerator Fade2()
    {
        for (; ; )
        {
            Color color = cube.GetComponent<MeshRenderer>().material.color;
            Color newcolor = Color.Lerp(color, Color.green, 0.1f);
            cube.GetComponent<MeshRenderer>().material.color = newcolor;
            yield return new WaitForSeconds(0.1f);
            if (Mathf.Abs(Color.green.g - newcolor.g) <= 0.03f)
            {
                break;
            }
        }
    }

    IEnumerator ChangeColor()
    {
        print("HelloColor");
        yield return new WaitForSeconds(3);
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        print("-------");
        yield return null; 
    } 
  
}
/*
 * In most situations, when you call a method, 
 * it runs to completion and then returns control to the calling method,
 * plus any optional return values. 
 * This means that any action that takes place within a method must happen within a single frame update.
    //携程方法 IEnumerator 不能直接调用
    //携程方法不会阻塞当前方法运行
    //暂停： yield return new WaitForSeconds(时间);
    //返回：yield return null/0;
    //本程序执行顺序：hhhhh->Hello Corlor->------
 */