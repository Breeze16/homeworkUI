using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button1_Move : MonoBehaviour {  
    public GameObject Panel;
    private float x = 0; 
    private float y = 85;
    private float cur_x;
    private float cur_y; 

    void Start() {  
        cur_x = x;  
        cur_y = y;
    }  

    void Update() {  
        if (Panel.transform.Find("Image").gameObject.activeSelf == false) Back();//回退
        Panel.transform.Find("Image1").gameObject.GetComponent<RectTransform>().localPosition = new Vector3(cur_x, cur_y - 55, 0);//公告跟随
    }

    void Back() {
        GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);//返回  
        cur_y = y;//更新
    }

    void OnCollisionEnter2D(Collision2D coll) {
        RectTransform coll_Tranform = coll.gameObject.GetComponent<RectTransform>();  
        GetComponent<RectTransform>().localPosition = new Vector3(x, y - coll_Tranform.sizeDelta.y, 0);//移动一个公告的高度
        cur_y = y - coll_Tranform.sizeDelta.y;//更新
    }  
} 
