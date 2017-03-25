using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBinSpawner : MonoBehaviour {

    public GameObject recycleBinPrefab = new GameObject();
    //public float recycleBinY = -0.17f;
    //public float recyclebinX = 24f;
    //public float recyclebinZ = 8f;
    public Vector3 pos1 = Vector3.zero;
    public Vector3 pos2 = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        GameObject recycleBin1 = Instantiate(recycleBinPrefab) as GameObject;
        GameObject recycleBin2 = Instantiate(recycleBinPrefab) as GameObject;
        
        pos1.x = 24f;
        pos1.z = 14.23f;
        pos2.x = 78.3f;
        pos2.z = 13.81f;

        recycleBin1.transform.position = pos1;
        recycleBin2.transform.position = pos2;

        // TODO: Fix code so it spawns one of the bins as a different color

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
