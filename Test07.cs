using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    public cube cube1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.isActiveAndEnabled);//�ж������Ƿ��Ǽ����
        Debug.Log(this.enabled);//�ж������Ƿ��Ǽ����
        enabled = false;//����
        Debug.Log(name);
        Debug.Log(tag);
        Debug.Log(gameObject);
        Debug.Log(transform);

        print("hhhhh");

        Debug.Log(cube1.isActiveAndEnabled);//�ж������Ƿ��Ǽ����
        Debug.Log(cube1.enabled);//�ж������Ƿ��Ǽ����
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
 * [ExecuteInEditMode]��һ������ 
 * �����ǣ��ڱ༭ģʽ��Ҳ�����У�һ����������ĳ�ʼ��
 * �÷� ֱ�Ӽӵ�ĳ������
 */