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
            //ֻ����һ֡����
            print("GetKeyDown");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ֻ����һ֡����
            print("GetKeyDown");

        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //ֻ����һ֡����
            print("GetKeyUp");

        }
        if (Input.GetKey(KeyCode.Space))
        {
            //������̧���һֱ����
            print("GetKey");
        }
        //������̺��������ܴ���
        if (Input.anyKeyDown)
        {
            print("anyKey");
        }


        //0����� 1���Ҽ� 2������
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
        
        //��ȡ����λ�� ��Ļ���½�Ϊԭ�� ����Ϊ��λ
        print(Input.mousePosition);
        //����:ͨ����괥����λ������ȡ�Ƿ񴥷�ĳ���¼�
        
    }
}
