using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletmoving : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=1f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) GameController.setDamage(1 + GameController.damage);
        else Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
