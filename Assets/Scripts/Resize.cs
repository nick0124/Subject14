using UnityEngine;
using System.Collections;

public class Resize : MonoBehaviour {

    public bool work;

    public bool ResizeX;
    private int ResizeXint;
    public bool ResizeY;
    private int ResizeYint;
    public float ResizeValue= 0.01f;
    public float MinSize = 0.1f;
    public float MaxSize = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        work = GameObject.Find("Playertest").GetComponent<PlayerControllerTest>().pultOn;
    }

	// Use this for initialization
	void Start () {
        //resize = Input.GetAxis("Horisontal");
        if (ResizeX) ResizeXint = 1;
        else ResizeXint = 0;

        if (ResizeY) ResizeYint = 1;
        else ResizeYint = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseOver()
    {
        //увеличивание
        if (Input.GetMouseButtonDown(0) && work)
        {
            if(transform.lossyScale.x<MaxSize || transform.lossyScale.y<MaxSize)
            transform.localScale = new Vector2(transform.localScale.x + ResizeValue * ResizeXint, transform.localScale.y + ResizeValue * ResizeYint);
        }
        //уменьшение
        if (Input.GetMouseButtonDown(1) && work)
        {
            if (transform.lossyScale.x > MinSize || transform.lossyScale.y > MinSize)
            transform.localScale = new Vector2(transform.localScale.x - ResizeValue * ResizeXint, transform.localScale.y - ResizeValue * ResizeYint);
        }
    }
}
