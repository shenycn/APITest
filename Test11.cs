using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{

    void Start()
    {
        print(Mathf.Rad2Deg);//57.29
        print(Mathf.Deg2Rad);//0.0174
        print(Mathf.PI);//3.141593
        print(Mathf.NegativeInfinity);//-infinity
        print(Mathf.Epsilon);//1.401298E-45
    }

    // Update is called once per frame
    void Update()
    {

    }
    #region Deg2Rad
    /*
     * Deg2Rad:�ȵ����Ȼ��㳣����ֻ������
       ������public static float Deg2Rad;
       ����ڡ�(PI* 2) / 360����
       Start is called before the first frame update
     */
    #endregion
    #region Deg2Rad
    /*
   * Deg2Rad:�ȵ����Ȼ��㳣����ֻ������
   *  ������public static float Deg2Rad;
   *  ����ڡ�(PI* 2) / 360����
   * Start is called before the first frame update
   */
    #endregion
    #region Rad2Deg
    /*
     * Rad2Deg�����ȵ��Ȼ��㳣����ֻ����
     * ������public static float Rad2Deg ;
     * ����ڡ�360 / (PI * 2)����
     */
    #endregion
    #region  Epsilon
    /*
     * Epsilon:΢С����ֵ��ֻ������
       ��������������������Сֵ��
       �������¹��� 
         �κ�ֵ + Epsilon = �κ�ֵ 
         �κ�ֵ - Epsilon = �κ�ֵ 
         0 + Epsilon = Epsilon 
         0 - Epsilon = -Epsilon
    �����κ������� Epsilon ֮���ֵ������������֣�
    ��Ϊ���� �ض���
     */

    #endregion
    #region NegativeInfinity
    //�������������ı�ʾ��ʽ��ֻ����
    #endregion
}