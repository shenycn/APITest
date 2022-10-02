using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        cube cube = target.GetComponent<cube>();//�õ�cube���
        Transform t = target.GetComponent<Transform>();//�õ�Trsanform���
        Debug.Log(cube);
        Debug.Log(t);
        Debug.Log("---------------------");

        cube[] cubes = target.GetComponents<cube>();//�õ����е�cube���
        Debug.Log(cubes.Length);//������鳤�� �˴���1
        Debug.Log("---------------------");

        /*GetComponentsInChildren<���>(); 
         *�����ǻ�ȡ�Լ������ĺ�����ͬ������������� Transform����
         *����һ�����飬��������Լ������ĺ��ӡ�
         *������ĺ��������е��ǲ���ԾSetActive(false);���ȡ������ 
         *���Ծͻ��еڶ�������GetComponentsInChildren<���>(true);
            *.GetComponentInParentͬ��
         */
        cubes = cube.GetComponentsInChildren<cube>();//�õ�����cube���
        foreach (cube c in cubes)
        {
            Debug.Log(c);//��ӡ��cube Cube1 Cube Cube2 Cube3
        }
        Debug.Log("---------------------");
        cube = target.GetComponentInParent<cube>();//�õ�����cube���
        foreach (cube c in cubes)
        {
            Debug.Log(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
