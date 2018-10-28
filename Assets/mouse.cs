using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

    private bool isMouseDown = false;
    private Vector3 lastMousePosition = Vector3.zero;
    public TextMesh target_ri;
    private Vector3 pos;

    // Use this for initialization
    void Start () {
        pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(Input.mousePosition);
        Debug.Log(transform.position);

        if (Input.GetMouseButtonDown(0) )
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;

            Vector3 temp = Input.mousePosition;
            if (transform.position.x >= 6.2 && transform.position.x <= 6.7 && transform.position.y >= 5.2 && transform.position.y <= 5.7)
            {
                target_ri.color = Color.red;
                Destroy(gameObject);
            }
            else
            {
                gameObject.transform.position = pos;
                lastMousePosition = Vector3.zero;
            }


        }
        if (isMouseDown )
        {
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                this.transform.position += offset;
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

	}

    bool check_mouse()
    {
        Vector3 temp = Input.mousePosition;
        if (temp.x >= 255 && temp.x <= 280 && temp.y >= 4 && temp.y <= 30) return true;
        return false;
    }
}
