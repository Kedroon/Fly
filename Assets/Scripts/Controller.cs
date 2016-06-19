using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Controller : MonoBehaviour {


    public float speed;
    public GameObject bullet;
    public GameObject bulletSpawn1;
    public GameObject bulletSpawn2;
    public GameObject playerBullets;
    public List<Material> skyboxes;
    public Text message;
    public Text pointsUI;
    public static Text staticpointsUI;
    public static int points = 0;
    private bool bulletspawn = false;

    // Use this for initialization
    void Awake() {
        Skybox skybox = Camera.main.GetComponent<Skybox>();
        skybox.material = skyboxes[Random.Range(0, 3)];
        staticpointsUI = pointsUI;
    }

	void Start () {
        StartCoroutine(messageDisappear());
        pointsUI.text = points.ToString();
	}
	
	// Update is called once per frame
	
    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

     
        

        if (moveHorizontal < 0 && transform.position.x <= -7f)
        {
            moveHorizontal = 0;
        }
        else if (moveHorizontal > 0 && transform.position.x >= 7f) {
            moveHorizontal = 0;
        }

        if (moveVertical > 0 && transform.position.y >= 4.6f) {
            moveVertical = 0;
        }
        else if (moveVertical < 0 && transform.position.y <= -3.45f)
        {
            moveVertical = 0;
        }
           
           

        Vector3 movement = new Vector3(moveHorizontal, moveVertical,0.0f );
        
        transform.Translate(movement * Time.deltaTime * speed,Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot() {
        GameObject Bullet = null;
        if (bulletspawn)
        {
            Bullet = Instantiate(bullet, bulletSpawn1.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
            bulletspawn = false;
        }
        else
        {
            Bullet = Instantiate(bullet, bulletSpawn2.transform.position, new Quaternion(0, 0, 0, 0)) as GameObject;
            bulletspawn = true;
        }
        Bullet.transform.SetParent(playerBullets.transform);
       // Bullet.transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Bullet.transform.Rotate(90, 0, 0);
        Bullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, 20));
    }

    IEnumerator messageDisappear() {
        yield return new WaitForSeconds(3);
        message.enabled = false;
    }

}

