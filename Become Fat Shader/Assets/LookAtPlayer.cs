using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 lookAtPosition = player.transform.position;
        lookAtPosition.y = transform.position.y;
        transform.LookAt(lookAtPosition);
    }
}
