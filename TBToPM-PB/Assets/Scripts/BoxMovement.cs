using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 2.0f;
    public float rotationSpeed;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.Find("Paul").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player != null)
        {
            Vector3 dir = player.position - transform.position;
            transform.position += (player.position - transform.position).normalized * movementSpeed * Time.deltaTime;
        }
    }
}
