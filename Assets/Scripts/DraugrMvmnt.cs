using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraugrMvmnt : MonoBehaviour
{

    [SerializeField] private Animator draugrAnimator;

    [SerializeField] private float movementSpeed =5f;
    [SerializeField] private Rigidbody2D draugrRB;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        draugrAnimator.SetFloat("Horizontal", movement.x);
        draugrAnimator.SetFloat("Vertical", movement.y);
        draugrAnimator.SetFloat("Speed", movement.sqrMagnitude);


    }

    private void FixedUpdate()
    {
        draugrRB.MovePosition(draugrRB.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
