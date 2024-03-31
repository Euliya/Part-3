using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    float speed = 0.1f;
    public Element element;
    protected Vector3 ptPosition = Vector3.zero;

    protected virtual void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Lerp(transform.position, ptPosition, speed*Time.deltaTime);
        if ((ptPosition - transform.position).magnitude < 2)
        {
            GameController.setDamage(1+GameController.damage);
            Destroy(gameObject);
            GameController.monsterCount--;
        }
             
    }

    public virtual IEnumerator Attack(GameObject target)
    {
        yield return null;
    }



}
