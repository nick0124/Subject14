using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public string TriggerName;
    public bool active = false;

    private float doorUpPos;

	// Use this for initialization
	void Start () {
        doorUpPos = transform.position.y + transform.lossyScale.y;
	}
	
	// Update is called once per frame
	void Update () 
    {
        active = GameObject.Find(TriggerName).GetComponent<Trigger>().Active;
        if (active)
        {
            //Debug.Log("Work");
            if (transform.position.y < doorUpPos)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + 0.01f);
            }
        }
	}
}
