using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    private float moventSpeed = 2f;
    private Rigidbody2D blob;

    private void Start()
    {
        blob = GetComponent<Rigidbody2D>();
    }

    public void Movement()
    { 
        blob.velocity = new Vector2(moventSpeed, 0);
        
    }


}
