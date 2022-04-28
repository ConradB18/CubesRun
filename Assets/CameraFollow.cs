using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public GameObject playercube; // Making a public variable for Player

    private Vector3 offset;
	
    // Start is called before the first frame update
    void Start()
    {
         offset = transform.position - playercube.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playercube.transform.position + offset; //Make Camera to player's transform position
    }
}
