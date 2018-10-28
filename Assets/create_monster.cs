using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_monster : MonoBehaviour {

    public GameObject add;
    static public int state = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(state==1)
            Instantiate(add, transform.position,transform.rotation);
	}
}
