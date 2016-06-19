using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(despawnBullet());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator despawnBullet() {

        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
