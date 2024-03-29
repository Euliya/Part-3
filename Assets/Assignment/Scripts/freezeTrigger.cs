using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeTrigger : MonoBehaviour
{
    public Ice ice;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(ice.Attack(collision.gameObject));
    }
}
