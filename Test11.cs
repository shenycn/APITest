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
     * Deg2Rad:度到弧度换算常量（只读）。
       声明：public static float Deg2Rad;
       这等于“(PI* 2) / 360”。
       Start is called before the first frame update
     */
    #endregion
    #region Deg2Rad
    /*
   * Deg2Rad:度到弧度换算常量（只读）。
   *  声明：public static float Deg2Rad;
   *  这等于“(PI* 2) / 360”。
   * Start is called before the first frame update
   */
    #endregion
    #region Rad2Deg
    /*
     * Rad2Deg：弧度到度换算常量（只读）
     * 声明：public static float Rad2Deg ;
     * 这等于“360 / (PI * 2)”。
     */
    #endregion
    #region  Epsilon
    /*
     * Epsilon:微小浮点值（只读）。
       浮点数可以与零相差的最小值。
       采用以下规则： 
         任何值 + Epsilon = 任何值 
         任何值 - Epsilon = 任何值 
         0 + Epsilon = Epsilon 
         0 - Epsilon = -Epsilon
    介于任何数字与 Epsilon 之间的值会产生任意数字，
    因为存在 截断误差。
     */

    #endregion
    #region NegativeInfinity
    //描述：负无穷大的表示形式（只读）
    #endregion
}