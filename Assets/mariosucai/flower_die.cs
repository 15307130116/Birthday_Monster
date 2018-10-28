using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flower_die : MonoBehaviour {

    public GameObject mario;
    private Vector3 position;
    public AudioSource source;
    public TextMesh live;

	// Use this for initialization
	void Start () {
        position =  mario.gameObject.transform.position;
        source.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "mario")
        {
            //死亡逻辑
            source.enabled = true;
            mario.GetComponent<SpriteRenderer>().color = Color.black;
            velocity.move_enable = false;

            Invoke("disable",3);
        }
    }

    void disable()
    {
        source.enabled = false;
        mario.transform.position = position;
        mario.GetComponent<SpriteRenderer>().color = Color.white;
        int age = int.Parse(live.text.Replace('X',' '));
        age--;
        live.text = "X" + age.ToString();
        velocity.move_enable = true;
    }

}
