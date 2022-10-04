using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    //���û��� Collider �ϰ�����갴ťʱ�������� OnMouseDown
    //��ʹ��겻�ڰ������ʱ���ڵ� Collider �ϣ�Ҳ����� OnMouseUp
    void OnMouseDown()
    {
        print("Down");
    }
    //���û��ɿ���갴ťʱ�������� OnMouseUp
     void OnMouseUp()
    {
        print("Up");
    }
    //���û����� Collider ����Ȼ��ס���ʱ�������� OnMouseDrag��
    private void OnMouseDrag()
    {
        print("Drag");
    }
    //�������� Collider ʱ���á�
    private void OnMouseEnter()
    {
        print("Enter");
    }
    //����겻�ٴ��� Collider �Ϸ�ʱ���á�
    //ע�⣺OnMouseExit ���ø�������Ӧ�� OnMouseEnter �� OnMouseOver ����֮��
    private void OnMouseExit()
    {
        print("Exit");
    }
    //�������ͣ�� Collider ��ʱ������괦�ڸö����Ϸ��ĵ�һ֡���ã�ÿ֡����һ�Ρ�
    private void OnMouseOver()
    {
        print("Over");  
    }
}
/*
 * Unity ͨ�������ڽű���������ĳЩ��������Ъ�ؽ�����Ȩ�����ű���
 * ����ִ����Ϻ󣬿���Ȩ������ Unity��
 * ��Щ������ Unity ��������Ӧ��Ϸ�з������¼�����˳�Ϊ�¼�����
 */

/*
 * Collider ������ײ��Ļ��ࡣ
 */