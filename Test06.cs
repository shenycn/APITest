using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        cube cube = target.GetComponent<cube>();//得到cube组件
        Transform t = target.GetComponent<Transform>();//得到Trsanform组件
        Debug.Log(cube);
        Debug.Log(t);
        Debug.Log("---------------------");

        cube[] cubes = target.GetComponents<cube>();//得到所有的cube组件
        Debug.Log(cubes.Length);//输出数组长度 此处是1
        Debug.Log("---------------------");

        /*GetComponentsInChildren<组件>(); 
         *这种是获取自己和它的孩子有同样的组件（比如 Transform），
         *返回一个数组，数组包括自己和它的孩子。
         *如果他的孩子里面有的是不活跃SetActive(false);则获取不到。 
         *所以就会有第二个参数GetComponentsInChildren<组件>(true);
            *.GetComponentInParent同理
         */
        cubes = cube.GetComponentsInChildren<cube>();//得到孩子cube组件
        foreach (cube c in cubes)
        {
            Debug.Log(c);//打印了cube Cube1 Cube Cube2 Cube3
        }
        Debug.Log("---------------------");
        cube = target.GetComponentInParent<cube>();//得到父亲cube组件
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
