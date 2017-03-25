using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySmoke : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 3.0f /*GetComponent<ParticleSystem>().duration*/);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
