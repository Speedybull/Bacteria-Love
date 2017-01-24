using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour {

	public float minForce = 20f;
	public float maxForce = 40f;
	public float minX = -0.5f;
	public float maxX = 0.5f;
	public float minY = -0.5f;
	public float maxY = 0.5f;

	public Rigidbody2D rb;
	public float DirectionChange = 0.5f;

	private float directionInterval;

	// Use this for initialization
	void Start () {
		directionInterval = DirectionChange;

		rb = GetComponent<Rigidbody2D> ();
		Push ();
	}
	
	// Update is called once per frame
	void Update () {

		directionInterval -= Time.deltaTime;
		if (directionInterval < 0) {
			Push ();
			directionInterval = DirectionChange;
		}
		
	}

	void Push()
	{
		float force = Random.Range (minForce, maxForce);
		float x = Random.Range (minX, maxX);
		float y = Random.Range (minY, maxY);

		rb.AddForce (force * new Vector2(x,y));
	}
}
