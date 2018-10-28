using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checkinput : MonoBehaviour {

    static public int age;
    public InputField name_;
    public InputField age_input;
    public InputField psw;
    public Text txt;
    static public string name;

	// Use this for initialization
	void Start () {
        txt.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        name = name_.text;
        if(psw.text == "sunshine2019")
        {
            try
            {
                Debug.Log(age_input.text);
                int a1 = int.Parse(age_input.text);
                Debug.Log(a1);
            }catch
            {
                txt.text = "年龄格式有误！";
            }
            age = int.Parse(age_input.text);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            txt.text = "账号密码错误！";
        }


    }
}
