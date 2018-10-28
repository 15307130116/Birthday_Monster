using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour {

    public GameObject kongtou;

	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
		if(gun.gift_state == 1)
        {
            gun.gift_state = 0;
            Invoke("down", 3);
        }
	}

    void down()
    {
        kongtou.active = true;
    }
}
