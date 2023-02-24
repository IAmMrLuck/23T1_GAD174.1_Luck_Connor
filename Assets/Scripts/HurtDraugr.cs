using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HurtDraugr : MonoBehaviour
{
    [SerializeField] private UnityEvent hurtDraugr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Draugr"))
        {
            hurtDraugr.Invoke();

        }
    }

}