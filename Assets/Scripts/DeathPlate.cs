using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathPlate: MonoBehaviour
{
    [SerializeField] private UnityEvent deathPlate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        deathPlate.Invoke();
    }

}
