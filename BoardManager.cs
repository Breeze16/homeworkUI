using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour {
    public GameObject Panel;
    public void Controller(GameObject obj) {  
        bool button = obj.GetComponent<Board>().Button;  
        button = !button;  
        obj.GetComponent<Board>().Button = button;  
        obj.SetActive(button);
    }

    void Start () {
        List<string> btnsName = new List<string>();
        btnsName.Add("Button");
        btnsName.Add("Button1");
        btnsName.Add("Button2");

        foreach(string btnName in btnsName) {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate() {
                this.OnClick(btnObj); 
            });
        } 
    }

    public void OnClick(GameObject tmp) {
        GameObject Image;
        switch (tmp.name) {
        case "Button":
            Image = Panel.transform.Find("Image").gameObject;
            Controller (Image);
            break;
        case "Button1":
            Image = Panel.transform.Find("Image1").gameObject;
            Controller (Image);
            break;
        case "Button2":
            Image = Panel.transform.Find("Image2").gameObject;
            Controller (Image);
            break;
        default:
            break;
        }
    }
} 
