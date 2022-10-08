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
 * �� a �� b ֮�䰴 t �������Բ�ֵ��
 * ���� t �����ڷ�Χ [0, 1] �ڡ�
    �� t = 0 ʱ������ a ��
    �� t = 1 ʱ������ b ��
    �� t = 0.5 ʱ������ a �� b ���е㡣
 */