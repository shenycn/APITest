using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //1.��ʼʱ���ɶ��� �յ�
        //GameObject go= new GameObject("Cube2");
        //2.����prefbʵ���� /��������һ����Ϸ������п�¡
        GameObject.Instantiate(prefab);
        //3.����Ϸ�д�����plane����������ʧ
        GameObject go=GameObject.CreatePrimitive(PrimitiveType.Plane);
        go.AddComponent<Rigidbody>();//Ϊ������Ӹ���
        //go.AddComponent<API01EventFunction>();
        //���� GameObject �� Scene ���Ƿ��ڻ״̬
        Debug.Log(go.activeInHierarchy);//TRUE
        //���ݸ�����ֵ true �� / false /������ / ͣ�� GameObject
        go.SetActive(false);

        {
            Debug.Log(go.activeInHierarchy);//false
        }
        Debug.Log(go.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
