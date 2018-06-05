using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button2_Move : MonoBehaviour {  

    public GameObject Panel;  
    private float cur_x;  
    private float cur_y;
    private float x = 0;  
    private float y = 30;  
    private float x1 = 0;  
    private float y1 = -20;  

    void Start() {  
        cur_x = x;  
        cur_y = y;  
    }  

    void Update() {
        if (Panel.transform.Find ("Image").gameObject.activeSelf != Panel.transform.Find ("Image1").gameObject.activeSelf)
            Back2 ();
        if (Panel.transform.Find("Image").gameObject.activeSelf == false) {  
            if (Panel.transform.Find("Image1").gameObject.activeSelf == false) Back1();  
        }
        Panel.transform.Find("Image2").gameObject.GetComponent<RectTransform>().localPosition = new Vector3(cur_x, cur_y - 55, 0);//实时更新Image3，保证Image3在Button3下方  
    }  

    void Back1() {  
        GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);  
        cur_y = y;
    }  

    void Back2() {  
        GetComponent<RectTransform>().localPosition = new Vector3(x1, y1, 0);  
        cur_y = y1;
    }  

    void OnCollisionEnter2D(Collision2D coll) {  
        RectTransform coll_Tranform = coll.gameObject.GetComponent<RectTransform>();
        GetComponent<RectTransform> ().localPosition = new Vector3 (cur_x, cur_y - coll_Tranform.sizeDelta.y, 0);
        cur_y = cur_y - coll_Tranform.sizeDelta.y;
    }  
}
