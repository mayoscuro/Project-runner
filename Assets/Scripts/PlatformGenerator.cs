using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    public GameObject platform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float DistanceBetweenMin;
    public float DistanceBetweenMax;

    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformsWidths;
    private float lastPlatformWidth = 0;
    //public ObjectPooler theObjectPool;


	// Use this for initialization
	void Start () {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;

        platformsWidths = new float[thePlatforms.Length];
        for (int i = 0; i < thePlatforms.Length; i++) {
            platformsWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < generationPoint.position.x) {
            distanceBetween = Random.Range(DistanceBetweenMin,DistanceBetweenMax);

            platformSelector = Random.Range(0, thePlatforms.Length);

            transform.position = new Vector3(transform.position.x + platformsWidths[platformSelector]+distanceBetween + lastPlatformWidth,transform.position.y,transform.position.z);

            

            Instantiate(/*platform*/thePlatforms[platformSelector],transform.position,transform.rotation);

            lastPlatformWidth = thePlatforms[platformSelector].GetComponent<BoxCollider2D>().size.x;

            //Object pooler:
            /*GameObject newPlatform = theObjectPool.GetPooledObject();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);*/

        }
	}
}
