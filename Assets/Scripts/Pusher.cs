using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Time")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) - 0.01f, Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y) - 0.01f);
        }
    }
}
