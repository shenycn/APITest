using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        /*通过使用零参数，该接收方法可选择忽略 /parameter/。
         * 如果选项设置为 SendMessageOptions.RequireReceiver，
         * 则在任何组件均未拾取此消息时输出错误。
         */
        //父类向子类发送消息 并且需要有接收者
      //  target.BroadcastMessage("Attack",null,SendMessageOptions.DontRequireReceiver);
        
        //只调用目标上的所有脚本
       // target.SendMessage("Attack", null, SendMessageOptions.DontRequireReceiver);

        //从子孙向父类/爷爷调用
        target.SendMessageUpwards("Attack", null, SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
