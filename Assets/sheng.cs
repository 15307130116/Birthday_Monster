using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheng : MonoBehaviour {

    public TextMesh target_sheng;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "mario")
        {
            Destroy(gameObject);
            target_sheng.color = Color.red;
        }
        
    }

}
