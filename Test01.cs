

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
     * 调用 Reset 可以在脚本首次附加到gameobject时
     * 以及使用 Reset 命令时初始化脚本的属性。
     * 相当于里面的构造函数
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
     * 每当设置脚本的属性时都会调用 OnValidate，包括反序列化对象时，
     * 这可能发生在不同的时间，例如在编辑器中打开场景时和域重新加载后
     * 本程序中调用了两次
     */
        print("OnValidate");
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        /*调用频度常常超过 Update
         * 如果帧率很低，可以每帧调用该函数多次
         * 如果帧率很高，可能在帧之间完全不调用该函数。
         * 在 FixedUpdate 之后将立即进行所有物理计算和更新。
         * 这是因为 FixedUpdate 的调用基于可靠的计时器（独立于帧率）
         */
        print("FixedUpdate");
    }
    void OnApplicationPause()
    {
        //要在下一帧开始前才有体现
        /*在帧的结尾处调用此函数（在正常帧更新之间有效检测到暂停）。
         * 在调用 OnApplicationPause 之后，
         * 将发出一个额外帧，从而允许游戏显示图形来指示暂停状态。
         */
        print("OnApplicationPause");
    }
    void Update()
    {
        print("Update");
    }

}
