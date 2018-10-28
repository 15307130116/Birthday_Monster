using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

    public GameObject airplane;
    public GameObject gift;
    static public int gift_state = 0;

	// Use this for initialization
	void Start () {
        airplane.active = false;
        gift.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        airplane.active = true;
        gift_state = 1;
        Destroy(gameObject);
    }

}
