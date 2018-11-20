using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public PlayerController player;
    private Vector3 lastaPlayerPosition;
    private float distanceToMove;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        lastaPlayerPosition = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        distanceToMove = player.transform.position.x - lastaPlayerPosition.x;

        transform.position = new Vector3(transform.position.x  + distanceToMove, transform.position.y, transform.position.z);

        lastaPlayerPosition = player.transform.position;
	}
}
