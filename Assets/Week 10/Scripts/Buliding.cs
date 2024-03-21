using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buliding : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public GameObject BW;
    public GameObject CF;
    public GameObject CR;
    float interpolation;
    public AnimationCurve building;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(brick());
        
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    // Update is called once per frame
    IEnumerator brick()
    {
        Instantiate(BW, Point1.position, Point1.rotation,Point1);
        Point1.localScale = Vector3.zero;
        while (Point1.localScale.x < 1)
        {
            interpolation = building.Evaluate(timer);
            Point1.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, interpolation);
            yield return null;
        }
        timer = 0;
               
        Instantiate(CF, Point2.position, Point2.rotation, Point2);
        Point2.localScale = Vector3.zero;
        while (Point2.localScale.x < 1)
        {
            interpolation = building.Evaluate(timer);
            Point2.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, interpolation);
            yield return null;
        }
        timer = 0;

        Instantiate(CR, Point3.position, Point3.rotation, Point3);
        Point3.localScale = Vector3.zero;
        while (Point3.localScale.x < 1)
        {
            interpolation = building.Evaluate(timer);
            Point3.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, interpolation);
            yield return null;
        }
    }
}
