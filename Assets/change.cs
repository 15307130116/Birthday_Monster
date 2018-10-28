using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour {

    public Text txt;
    public Image moon;
    public Image candle;
    //public Image black;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("changeword", 19);
	}

    void changeword()
    {
        candle.enabled = false;
        moon.color = Color.blue;
        txt.text = "祝" + checkinput.name + checkinput.age.ToString() + "岁\n生日快乐！\n天天进步！";
    }


}
