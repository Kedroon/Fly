using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour {

    public float speed;
    private int life;
    public GameObject Explosion;
    public GameObject naveModel;
    public 

	void Start () {
        life = 1;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Debug.Log("acertou");
            life--;
            if (life==0)
            {
                GameObject explosion = Instantiate(Explosion, transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
                explosion.transform.SetParent(transform);
                naveModel.SetActive(false);
                gameObject.GetComponent<BoxCollider>().enabled = false;
                Controller.points += 10;
                Controller.staticpointsUI.text = Controller.points.ToString();
                //Destroy(gameObject);
            }
        }
        
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed*Time.deltaTime);
	}
}
