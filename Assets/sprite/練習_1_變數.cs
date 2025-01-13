using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 練習_1_變數 : MonoBehaviour
{
    /// <summary>
    /// 第一題
    /// </summary>
    public int price;
    /// <summary>
    /// 第二題
    /// </summary>
    private float Jumpheight;
    /// <summary>
    /// 第三題
    /// </summary>
    public string arms;
    /// <summary>
    /// 第四題
    /// </summary>
    private bool DragonSoul;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        price =999;
        Jumpheight = 77.5f;
        arms = "三項之力";
        DragonSoul =true ;



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
