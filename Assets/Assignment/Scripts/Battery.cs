using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
enum Element{fire, ice}

public class Battery : MonoBehaviour
{
    public Slider slider;
    public Graphic graphic;
    public Color iceColor,fireColor;
    public float waitingTime=5f;
    static Element element;
    public Transform zzTransfrom;
    public GameObject ibulletPrefab, fbulletPrefab;
    public Transform bulletPoint;
    Coroutine shooting;

    // Start is called before the first frame update
    void Start()
    {
        setElement(Element.fire);

        slider.maxValue = waitingTime;
        slider.value = waitingTime * 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(shooting != null) {
                StopCoroutine(Shoot()); 
            }
            shooting=StartCoroutine(Shoot());

        }

        if (Input.GetMouseButtonDown(1) && shooting == null)
        {
            if (element == Element.fire)
            {
                setElement(Element.ice);
            }
            else
            {
                setElement(Element.fire);
            }
        }
        //zz point to mouse
        if (shooting == null)
        {
            Vector3 mousePostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePostion - zzTransfrom.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            zzTransfrom.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    IEnumerator Shoot()
    {
        slider.value = waitingTime * 0.1f;
        while (slider.value < waitingTime) {
            slider.value+=Time.deltaTime;
            yield return 0;
        }
        if(element==Element.ice)
            Instantiate(ibulletPrefab, bulletPoint.position, bulletPoint.rotation);
        else Instantiate(fbulletPrefab, bulletPoint.position, bulletPoint.rotation);
        slider.value = waitingTime * 0.1f;
        shooting = null;
    }

    void setElement(Element e)
    {
        element = e;
        if (element == Element.fire)graphic.color = fireColor;
        else graphic.color = iceColor;
    }

    

}
