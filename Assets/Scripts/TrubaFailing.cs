using UnityEngine;
using System.Collections;

public class TrubaFailing : MonoBehaviour {

    public string TriggerName;
    public bool active = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        active = GameObject.Find(TriggerName).GetComponent<Trigger>().Active;
        if (active)
        {
            //Debug.Log("Work");
            transform.GetComponent<Rigidbody2D>().isKinematic = false;
        }
	}
}
