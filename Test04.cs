using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //1.开始时生成对象 空的
        //GameObject go= new GameObject("Cube2");
        //2.根据prefb实例化 /根据另外一个游戏物体进行克隆
        GameObject.Instantiate(prefab);
        //3.在游戏中创建个plane，结束后消失
        GameObject go=GameObject.CreatePrimitive(PrimitiveType.Plane);
        go.AddComponent<Rigidbody>();//为物体添加刚体
        //go.AddComponent<API01EventFunction>();
        //定义 GameObject 在 Scene 中是否处于活动状态
        Debug.Log(go.activeInHierarchy);//TRUE
        //根据给定的值 true 或 / false /，激活 / 停用 GameObject
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
