using UnityEngine;
using System.Collections;

public class PlayerControllerTest : MonoBehaviour {

    public float move;

    public float maxSpeed = 10f;
    public float jumpForce = 700f;
    public bool facingRight = true;
    bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;

	Animator anim;

    public bool pultOn;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("ground", grounded);
		anim.SetFloat("Speed", Mathf.Abs(move));
        anim.SetBool("pultOnAnim", pultOn);

		move = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pultOn = !pultOn;
        }
        if (!pultOn)
        {
            rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
        }

    }
	
	// Update is called once per frame
    void Update()
    {
        if (!pultOn)
        {
            if (grounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
            {
                anim.SetBool("ground", false);
                rigidbody2D.AddForce(new Vector2(0f, jumpForce));


            }
        }

        
    

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();



        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
