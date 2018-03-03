using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float delay = 2;
	public string enemyTag;

	void OnTriggerEnter(Collider col)
    {
		Debug.Log(col.gameObject.tag);
		if(col.gameObject.tag == enemyTag)
		{
            Debug.Log("True");
            StartCoroutine("Delay");
		}
	}

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        Debug.Log("Destroy");
    }
}
