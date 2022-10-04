using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    //当用户在 Collider 上按下鼠标按钮时，将调用 OnMouseDown
    //即使鼠标不在按下鼠标时所在的 Collider 上，也会调用 OnMouseUp
    void OnMouseDown()
    {
        print("Down");
    }
    //当用户松开鼠标按钮时，将调用 OnMouseUp
     void OnMouseUp()
    {
        print("Up");
    }
    //当用户单击 Collider 并仍然按住鼠标时，将调用 OnMouseDrag。
    private void OnMouseDrag()
    {
        print("Drag");
    }
    //当鼠标进入 Collider 时调用。
    private void OnMouseEnter()
    {
        print("Enter");
    }
    //当鼠标不再处于 Collider 上方时调用。
    //注意：OnMouseExit 调用跟随在相应的 OnMouseEnter 和 OnMouseOver 调用之后。
    private void OnMouseExit()
    {
        print("Exit");
    }
    //当鼠标悬停在 Collider 上时，在鼠标处于该对象上方的第一帧调用，每帧调用一次。
    private void OnMouseOver()
    {
        print("Over");  
    }
}
/*
 * Unity 通过调用在脚本中声明的某些函数来间歇地将控制权交给脚本。
 * 函数执行完毕后，控制权将交回 Unity。
 * 这些函数由 Unity 激活以响应游戏中发生的事件，因此称为事件函数
 */

/*
 * Collider 所有碰撞体的基类。
 */