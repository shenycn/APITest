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
        Debug.Log(cube.position);//��ʼλ��000
        cube.position =new Vector3(Mathf.Clamp(timeValue, xMin, xMax), xMin, xMax);//����cube�ƶ�
        Debug.Log(cube.position);
    }
    private float hp = 100;
    void TakeDamage()
    {

        hp -= 9;
        hp = Mathf.Clamp(hp, 0, 100);
    }
}

#region Mathf�ĺ���
// Mathf.Abs:���� f �ľ���ֵ��

// Mathf.Approximately:�Ƚ���������ֵ������������ƣ��򷵻� true��

// Approximately() �Ƚ���������������������໥֮��Ĳ�ֵ���ڽ�Сֵ (Epsilon) ��Χ�ڣ��򷵻� true��

// Mathf.CeilTolnt:���ش��ڻ���� f ����С������(�������͵�)

// Mathf.Ceil:���ش��ڻ���� f ����С�������������ͣ�

// Math.Clamps:����minimum ��maximum֮���ֵ 
// ������public static float Clamp (float value, float min, float max);
//  value:�޶������ֵ����Сֵ֮��ĸ����� min:Ҫ�Ƚϵ���С����ֵ max��Ҫ�Ƚϵ���󸡵�ֵ
//  ���ã���һ��ֵ�޶���һ����Χ֮��
#endregion