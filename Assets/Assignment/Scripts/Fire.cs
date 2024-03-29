using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fire : Monster
{
    public float waitingTime = 1f;
    public GameObject firebullPrefab;
    public Transform Mpoint;
    // Start is called before the first frame update
    protected override void Start()
    {
        Vector3 direction = (ptPosition - Mpoint.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        Mpoint.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        StartCoroutine(Attack(gameObject));
    }

    //fire attck: shoot a bullet towards player, several second per bullet
    public override IEnumerator Attack(GameObject target)
    {
        while (true)
        {
            Instantiate(firebullPrefab, Mpoint.position, Mpoint.rotation);
            yield return new WaitForSeconds(waitingTime);
        }
    }
}
