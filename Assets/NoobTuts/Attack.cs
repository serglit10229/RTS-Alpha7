using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    // attack range
    public float range = 5;

    // attack interval
    public float interval = 1.5f;
    
    // tag of the unit that should be attacked
    public string enemyTag = "";

    // arrow prefab (to shoot at enemies)
    public GameObject arrow;

    // check if player2(NPC)
    public bool Player2 = false;

    // Use this for initialization
    void Start() {
        InvokeRepeating("Fire", interval, interval);
    }
    
    void Fire() {
        Debug.Log("Fire");
        foreach (GameObject g in GameObject.FindGameObjectsWithTag(enemyTag)) {
            // still alive?
            Debug.Log("Fire2");
            if (g != null) {
                // in attack range?		
                Debug.Log("Fire3");
                if (Vector3.Distance(g.transform.position, transform.position) <= range) {
                    // shoot arrow at it
                    Debug.Log("Fire4");
                    GameObject a = (GameObject)Instantiate(arrow, 
                                                           transform.position, // default position
                                                           Quaternion.identity); // default rotation
                    
                    // set its target
                    a.GetComponent<Arrow>().target = g.transform;

                    // set its enemyTag
                    if(Player2 == false)
                    {
                        a.GetComponent<Destroy>().enemyTag = "Enemy";
                    }
                    if (Player2 == true)
                    {
                        a.GetComponent<Destroy>().enemyTag = "Player";
                    }

                    // animation
                    GetComponent<PlayCurve>().Toggle();
                    
                    // done for now
                    break;
                }
            }
        }
    }
}
