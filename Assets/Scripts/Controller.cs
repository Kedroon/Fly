using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


    public float speed;
   
	// Use this for initialization
	void Start () {
	
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
        
    }
}
