

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    private void Awake()
    {
        print("Awake");
    }
    private void OnEnable()
    {
        print("OnEnable");
    }
    

    private void Reset()
    {
     /*
     * ���� Reset �����ڽű��״θ��ӵ�gameobjectʱ
     * �Լ�ʹ�� Reset ����ʱ��ʼ���ű������ԡ�
     * �൱������Ĺ��캯��
     */
        print("Reset");
    }
    void Start()
    {
        print("Start");
    }
    
    void OnValidate()
    {
     /*
     * ÿ�����ýű�������ʱ������� OnValidate�����������л�����ʱ��
     * ����ܷ����ڲ�ͬ��ʱ�䣬�����ڱ༭���д򿪳���ʱ�������¼��غ�
     * �������е���������
     */
        print("OnValidate");
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        /*����Ƶ�ȳ������� Update
         * ���֡�ʺܵͣ�����ÿ֡���øú������
         * ���֡�ʺܸߣ�������֮֡����ȫ�����øú�����
         * �� FixedUpdate ֮���������������������͸��¡�
         * ������Ϊ FixedUpdate �ĵ��û��ڿɿ��ļ�ʱ����������֡�ʣ�
         */
        print("FixedUpdate");
    }
    void OnApplicationPause()
    {
        //Ҫ����һ֡��ʼǰ��������
        /*��֡�Ľ�β�����ô˺�����������֡����֮����Ч��⵽��ͣ����
         * �ڵ��� OnApplicationPause ֮��
         * ������һ������֡���Ӷ�������Ϸ��ʾͼ����ָʾ��ͣ״̬��
         */
        print("OnApplicationPause");
    }
    void Update()
    {
        print("Update");
    }

}
