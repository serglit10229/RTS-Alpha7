using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class MoveByPlayer : MonoBehaviour {
    // Selection Circle
    public GameObject circle;
    public NavMeshAgent agent;

    public Vector3 dest;

    
    // Update is called once per frame
    void Update () {
        // Rightclicked while selected?
        if (Input.GetMouseButtonDown(1) && circle.activeSelf) {
            // Find out where the user clicked in the 3D world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                GetComponent<UnityEngine.AI.NavMeshAgent>().destination = hit.point;
                dest = hit.point;
                Debug.Log("Move");
                Debug.Log(dest);

            }
        }
        /*
        float dist = agent.remainingDistance;

        if (dist != Mathf.Infinity && agent.pathStatus == NavMeshPathStatus.PathComplete && agent.remainingDistance == 0)
        {
            Debug.Log("stop");
            GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
        }
        */
    }
}
