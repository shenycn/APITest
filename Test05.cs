using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        /*ͨ��ʹ����������ý��շ�����ѡ����� /parameter/��
         * ���ѡ������Ϊ SendMessageOptions.RequireReceiver��
         * �����κ������δʰȡ����Ϣʱ�������
         */
        //���������෢����Ϣ ������Ҫ�н�����
      //  target.BroadcastMessage("Attack",null,SendMessageOptions.DontRequireReceiver);
        
        //ֻ����Ŀ���ϵ����нű�
       // target.SendMessage("Attack", null, SendMessageOptions.DontRequireReceiver);

        //����������/үү����
        target.SendMessageUpwards("Attack", null, SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
