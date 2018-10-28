using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour {

    public TextMesh live;

	// Use this for initialization
	void Start () {
        live.text = "X"+checkinput.age.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
