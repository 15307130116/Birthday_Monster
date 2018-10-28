using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkend : MonoBehaviour {

    public TextMesh sheng;
    public TextMesh ri;
    public TextMesh kuai;
    public TextMesh le;
    public TextMesh live;
    public GameObject bgm;


	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(sheng.color == Color.red && ri.color == Color.red && kuai.color == Color.red && le.color == Color.red)
        {
            
            Invoke("change", 1);
            Invoke("change2", 20);
        }
	}

    void change()
    {
        bgm.GetComponent<AudioSource>().enabled = false;
        GetComponent<AudioSource>().enabled = true;
        velocity.move_enable = false;
        live.text = checkinput.name+"\n大吉大利，记得吃生日蛋糕哦！";
        live.color = Color.yellow;
        create_monster.state = 1;
        
    }

    void change2()
    {
        SceneManager.LoadScene("end");
    }
}
