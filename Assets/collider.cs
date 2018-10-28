using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {

    public GameObject star;
    public Sprite after_;
    public AudioSource audio;


	// Use this for initialization
	void Start () {

        if (audio != null)
        {
            audio.enabled = false;
        }

        star.active = false;
        Debug.Log("come in");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.transform.position.y < gameObject.transform.position.y)
        {
            if(star!=null)
                star.active = true;
            GetComponent<SpriteRenderer>().sprite = after_;
            Debug.Log("hi");
            audio.enabled = true;
        }
    }

}
