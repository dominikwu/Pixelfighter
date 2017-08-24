using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {
    private Rigidbody   rb;
    private Objectstats Stats;
    private Ray         Camray;
    private RaycastHit  floorhit;
    private int         floormask ; 
    private float       CamrayLength = 1000f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        floormask = LayerMask.GetMask("Floor");
        Stats = GetComponent<Objectstats>();

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) ;
        rb.velocity = rb.velocity.normalized * Time.deltaTime * Stats.speed;

#region Player Rotates to the Mousepointer

        Camray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(Camray, out floorhit, CamrayLength, floormask ))
        {
            Vector3 PlayerToMouse = floorhit.point - rb.position;
            PlayerToMouse.y = 0f;
            Quaternion newQuaternion = Quaternion.LookRotation(PlayerToMouse);
            //newQuaternion.x = 0f;
            //newQuaternion.z = 0f;
            rb.rotation = newQuaternion;
        }
#endregion
    }
}
