using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthAnim : MonoBehaviour
{
    [SerializeField] private UnityEvent myEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myEvent.Invoke();
    }

}
