using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{
    private float xMin = 0.0f, xMax = 3.5f;
    private float timeValue = 0.0f;
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        if (Mathf.Approximately(1.0f, 10.0f / 10.0f))
        {
            print("The values are approximately the same");
        }
        Debug.Log(Mathf.Abs(-1.343f));
        Debug.Log(Mathf.CeilToInt(9.9999f));

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cube.position);//初始位置000
        cube.position =new Vector3(Mathf.Clamp(timeValue, xMin, xMax), xMin, xMax);//控制cube移动
        Debug.Log(cube.position);
    }
    private float hp = 100;
    void TakeDamage()
    {

        hp -= 9;
        hp = Mathf.Clamp(hp, 0, 100);
    }
}

#region Mathf的函数
// Mathf.Abs:返回 f 的绝对值。

// Mathf.Approximately:比较两个浮点值，如果它们相似，则返回 true。

// Approximately() 比较两个浮点数，如果它们相互之间的差值处于较小值 (Epsilon) 范围内，则返回 true。

// Mathf.CeilTolnt:返回大于或等于 f 的最小整数。(整数类型的)

// Mathf.Ceil:返回大于或等于 f 的最小整数。（浮点型）

// Math.Clamps:返回minimum 和maximum之间的值 
// 声明：public static float Clamp (float value, float min, float max);
//  value:限定在最大值和最小值之间的浮点数 min:要比较的最小浮点值 max：要比较的最大浮点值
//  作用：吧一个值限定在一个范围之内
#endregion