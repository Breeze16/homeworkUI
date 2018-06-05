using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button_Move : MonoBehaviour {  
    public GameObject Panel;  
    private float cur_x = 0; 
    private float cur_y = 140;  
    void Update() {
        Panel.transform.Find("Image1").gameObject.GetComponent<RectTransform>().localPosition = new Vector3(cur_x, cur_y - 55, 0);
    }  
}  
