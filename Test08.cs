using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test08 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("Attack", 3);//3������
        InvokeRepeating("Attack", 4, 2); //��˼������֮�����һ�� ֮��ÿ����������һ��
        CancelInvoke("Attack");
    }
    private void Update()
    {
        bool res = IsInvoking("Attack");//�ж��Ƿ��ڵȴ�״̬
        //  print(res);//�˴�3��ǰ��true 3�����FALSE
        print(res);//ÿ������� ����һ��TRUE
    }
    // Update is called once per frame
    void Attack()
    {
        print("����Ŀ��");
    }
}
/*
 * CancelInvoke();����ָ������ʱ ȡ���������ĵ���
 * ��ָ������ ���ǰ����еķ�����ȡ��
 */