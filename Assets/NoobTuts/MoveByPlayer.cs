using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class MoveByPlayer : MonoBehaviour {
    // Selection Circle
    public GameObject circle;
    public NavMeshAgent agent;

    public bool shift = false;

    //public Vector3 dest;

    public List<Vector3> dest = new List<Vector3>();

    
    // Update is called once per frame
    void Update () {


        if (Input.GetKeyDown(KeyCode.LeftShift) && shift == false)
        {
            shift = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && shift == true)
        {
            shift = false;
        }

        // Rightclicked while selected?
        if (Input.GetMouseButtonDown(1) && circle.activeSelf) {
            // Find out where the user clicked in the 3D world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (!dest.Contains(hit.point))
                {
                    if (shift != true)
                    {
                        dest.Clear();
                    }
                    dest.Add(hit.point);


                }
            }
        }

        if(dest.Count != 0)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = dest[0];
        }

        if (transform.position.x == dest[0].x && transform.position.z == dest[0].z)
        {
            Debug.Log("Arrived");
            Debug.Log(dest.Count);
            if (dest.Count > 1)
            {
                GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
                GetComponent<UnityEngine.AI.NavMeshAgent>().destination = dest[1];
            }
            dest.RemoveAt(0);
            //GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
        }
    }
}
