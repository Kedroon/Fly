using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


    public float speed;
    public Animator animator;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical == 0)
        {
            animator.SetBool("IdleVertical", true);
        }
        else {
            animator.SetBool("IdleVertical", false);
        }
        

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
           Vector3 rotate = new Vector3(moveVertical,0.0f , moveHorizontal);
           print(transform.rotation.y);
       /*    if (moveVertical > 0 && transform.rotation.x > -0.2f )
            {
            // transform.Rotate(-rotate * speed, Space.World);
            transform.rotation = transform.rotation * Quaternion.AngleAxis(90 * Time.deltaTime, Vector3.left);
            // print("oi");
            //transform.Rotate(-80 * Time.deltaTime, 0, 0);
        }
           print(transform.rotation.z);
            if (moveVertical < 0 && transform.rotation.x < 0.42f) {
            //transform.parent.rotation=Quaternion.Lerp( transform.parent.rotation, Quaternion., 1));
            transform.rotation = transform.rotation * Quaternion.AngleAxis(90 * Time.deltaTime, Vector3.right);
            //transform.Rotate(-rotate * speed, Space.World);

            //transform.Rotate();
        }
           if (moveHorizontal > 0 && transform.rotation.z > -0.31f) {
               //transform.Rotate(-rotate * speed, Space.World);
               transform.rotation = transform.rotation* Quaternion.AngleAxis(90*Time.deltaTime, Vector3.back);

        }
           if (moveHorizontal < 0 && transform.rotation.z < 0.31f)
           {
            //transform.Rotate(-rotate * speed ,Space.World);
               transform.rotation = transform.rotation*  Quaternion.AngleAxis(90*Time.deltaTime, Vector3.forward);

        }*/
        //print(moveVertical);
        animator.SetFloat("Vertical", moveVertical);
   //     animator.SetFloat("Horizontal", moveHorizontal);
      //  print(animator.GetFloat("Horizontal"));

        Vector3 movement = new Vector3(moveHorizontal, moveVertical,0.0f );
        //transform.Rotate(rotate * speed);
        transform.Translate(movement * Time.deltaTime * speed,Space.World);
        
    }
}
