using UnityEngine;
using System.Collections;

public class RotateSpaceShip : MonoBehaviour {

    
    public Animator animator;
    public string direction;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis(direction);
        

        if (move == 0)
        {
            animator.SetBool("Idle", true);
        }
        else {
            animator.SetBool("Idle", false);
            
        }

        animator.SetFloat("Move", move);

    }
}
