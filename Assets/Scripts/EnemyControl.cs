using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {


    public GameObject enemy;
    private IEnumerator spawn1,spawn2;
	// Use this for initialization
	void Start () {
        spawn1 = spawnEnemy();
        spawn2 = spawnEnemy();
        StartCoroutine(spawn1);
        StartCoroutine(spawn2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator spawnEnemy() {
        while (true)
        {
           
            GameObject enem = Instantiate(enemy, new Vector3(transform.position.x+Random.Range(-5.7f,5.7f),transform.position.y+Random.Range(-1.5f,3.6f),transform.position.z), new Quaternion(0, 180, 0, 0)) as GameObject;
            enem.transform.SetParent(transform);
            yield return new WaitForSeconds(Random.Range(1,5));
        }

    }
}
