using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour {

    public int speed;
    public float jumpforce = 400f;
    private int left_right = 0;
    static public bool move_enable = true;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().enabled = false;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

	}

    // Update is called once per frame
    void FixedUpdate() {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && onground() && move_enable)
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpforce));
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && move_enable)
        {
            left_right = 1;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, GetComponent<Rigidbody2D>().velocity.y);
        }else if ((Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D)) && move_enable)
        {
            left_right = 0;
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }

        if(left_right == 1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }


	}

    bool onground()
    {
        GetComponent<AudioSource>().enabled = false;

        Bounds bounds = GetComponent<Collider2D>().bounds;
        float range = bounds.size.y * 0.4f;
        Vector2 v = new Vector2(bounds.center.x, bounds.min.y - range);
        RaycastHit2D hit = Physics2D.Linecast(v, bounds.center);
        return (hit.collider.gameObject != gameObject);

    }

    void audio_not_enable()
    {
        GetComponent<AudioSource>().enabled = false ;
    }


}
