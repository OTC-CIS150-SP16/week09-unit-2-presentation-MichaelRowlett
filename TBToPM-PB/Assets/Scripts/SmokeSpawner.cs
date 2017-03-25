using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeSpawner : MonoBehaviour {

    public float x;
    public float z;
    public int determiner;
    public int betterColorRandomizer;
    
    #region Game Objects
    public GameObject blueSmokePrefab = new GameObject();
    public GameObject redSmokePrefab = new GameObject();
    public GameObject blueBoxPrefab = new GameObject();
    public GameObject redBoxPrefab = new GameObject();
    public GameObject player = new GameObject();
    #endregion

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("SpawnSmoke", 3f, 3f);
        InvokeRepeating("BoxSpawn", 4f, 3f);
    }
	
    #region Spawn Methods
    public void SpawnSmoke()
    {
        #region Spawn Locations
        x = Random.Range(-36.5f, 36.5f);
        betterColorRandomizer = Random.Range(1, 101);

        if (x > -10 && x < 10)
        {
            z = Random.Range(10f, 20f);
            determiner = Random.Range(0, 2) * 2 - 1;

            z = z * determiner;
        }
        else
        {
            z = Random.Range(-20f, 20f);
        }
        #endregion
        #region Smoke Color
        if (betterColorRandomizer % 2 == 0)
        {
            GameObject smoke = Instantiate(blueSmokePrefab, new Vector3(x, 0, z), Quaternion.Euler(-90, 0, 0)) as GameObject;
        }
        else
        {
            GameObject redSmoke = Instantiate(redSmokePrefab, new Vector3(x, 0, z), Quaternion.Euler(-90, 0, 0)) as GameObject;
        }
        #endregion
    }

    public void BoxSpawn()
    {
        if (betterColorRandomizer % 2 == 0)
        {
            GameObject blueBox = Instantiate(blueBoxPrefab, new Vector3(x, 0, z), new Quaternion()) as GameObject;
        }
        else
        {
            GameObject redBox = Instantiate(redBoxPrefab, new Vector3(x, 0, z), new Quaternion()) as GameObject;
        }
        
    }
    #endregion
    
}
