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
            //һ��button���Զ�Ӧ������� ���ܴ���
            //��ctrl �����������ܴ���
            print("Fire1");
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            print("Horizontal");
        }
        Input.GetAxis("Horizontal");
        print(Input.GetAxis("Horizontal"));//ȡֵ0~-1
        //ʹ�����ƶ� ���������µ�Ч��
        cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")*10);
        //ʹ�����ƶ� ���������µ�Ч��
        //cube.Translate(Vector3.right * Time.deltaTime * Input.GetAxisRaw("Horizontal")*10);
    }
}
//bottom�������ⰴ��
