using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public float speed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed*Time.deltaTime);
	}
}
