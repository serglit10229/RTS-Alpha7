using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Stop : MonoBehaviour {


    bool off = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<NavMeshAgent>().isStopped = true;
            GetComponent<NavMeshAgent>().destination = transform.position;
            GetComponent<NavMeshAgent>().isStopped = false;
        }
        /*
        if (Input.GetKeyDown(KeyCode.F) && off == true)
        {
            GetComponent<NavMeshAgent>().isStopped = false;
            off = false;
        }
        */
    }
}
