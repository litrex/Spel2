using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour 
{

	// Use this for initialization
	public int deathtimer;
	public float speed;
	bool grounded = true;
	public float jump;
	public bool isLookingRight = true;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Ground")
		{
			grounded = true;	
		}
		if (coll.gameObject.tag == "Player")
		{
			grounded = true;
		}
		if (coll.gameObject.tag == "SpikeTrap")
		{
			Application.LoadLevel(0);
		}
		if (coll.gameObject.tag == "LavaPit")
		{
			Application.LoadLevel(0);
		}
		if (coll.gameObject.tag == "SpikeBlock")
		{
			Application.LoadLevel(0);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.I) && grounded == true)
		{
			rb.AddForce(Vector2.up * jump);

			grounded = false;
		}

		float speedX = Input.GetAxis("Horizontal2");
		float speedY = Input.GetAxis("Vertical");

		rb.velocity = new Vector2(speedX * speed, rb.velocity.y);

	/*	if(rb.velocity.x == 0)
		{
			deathtimer--;
		}

		if(deathtimer <= 0)
		{
			Destroy(gameObject);
		}

	*/	
		if (speedX > 0)
		{
			transform.localEulerAngles = new Vector3(0, 180, 0);
			isLookingRight = false;
		}

		if (speedX < 0)
		{
			transform.localEulerAngles = new Vector3(0, 0, 0);
			isLookingRight = true;
		}
	}

}
