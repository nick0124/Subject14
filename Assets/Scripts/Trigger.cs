using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    public bool Active = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //подсказка расстворяется в воздухе(если хватит времени)
            Active = true;
        }

    }
}
