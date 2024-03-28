using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    float speed = 0.1f;
    public GameObject firebullPrefab;
    public Transform Mpoint;
    Vector3 ptPosition = Vector3.zero;
    public float waitingTime=1f;
    //Transform startPointL;
    //Transform startPointR;
    //public Monster[]monster=new Monster[5];
    //int currentvalue = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = (ptPosition - Mpoint.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        Mpoint.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        StartCoroutine(Shoot());
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
             
    }
     IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(firebullPrefab, Mpoint.position, Mpoint.rotation);
            yield return new WaitForSeconds(waitingTime);
        }
    }


}
