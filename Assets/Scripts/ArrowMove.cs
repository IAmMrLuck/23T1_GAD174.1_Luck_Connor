using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    [SerializeField] private float arrowSpeed = 4f;

    private Rigidbody2D _arrow;

    private void Start()
    {
        _arrow = GetComponent<Rigidbody2D>();
    }

    public void ArrowMoves()
    {
        _arrow.velocity = new Vector2(-arrowSpeed, 0);

    }

}
