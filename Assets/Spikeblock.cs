using UnityEngine;
using System.Collections;

public class Spikeblock : MonoBehaviour 
{
	public float yPos1;
	public float yPos2;
	public Rigidbody2D rb;
	private Vector3 movement = Vector3.up * 0.05f;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.y > yPos1)
		{
			movement = Vector3.down * 0.05f;
		}
		if(transform.position.y < yPos2)
		{
			movement = Vector3.up * 0.05f;
		}
		transform.Translate(movement);
	}
}
