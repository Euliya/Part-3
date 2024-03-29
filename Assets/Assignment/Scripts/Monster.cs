using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    float speed = 0.1f;
    
    protected Vector3 ptPosition = Vector3.zero;

    //Transform startPointL;
    //Transform startPointR;
    //public Monster[]monster=new Monster[5];
    //int currentvalue = 0;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        //StartCoroutine(Shoot());
    }

    private void FixedUpdate()
    {
        
        //if (currentvalue< monster.Length)
        //{
        //    Instantiate(monsterPrefab, startPointL.position, startPointL.rotation);
        //    currentvalue++;
        //}


    }
    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Lerp(transform.position, ptPosition, speed*Time.deltaTime);
        if ((ptPosition - transform.position).magnitude < 2)
        {
            GameController.setDamage(1+GameController.damage);
            Destroy(gameObject);

        }
             
    }

    public virtual IEnumerator Attack(GameObject target)
    {
        yield return null;
    }



}
