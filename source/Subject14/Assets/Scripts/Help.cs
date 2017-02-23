using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {


	// Use this for initialization
	void Start () {
        //GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //подсказка расстворяется в воздухе(если хватит времени)
            Destroy(gameObject);
        }

    }
}
