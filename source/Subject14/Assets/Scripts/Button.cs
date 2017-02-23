using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public bool pressed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.rigidbody2D.mass > 1)
        {
            if (!pressed)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - transform.lossyScale.y / 2);
            }
            pressed = true;
            
        }
    }
}
