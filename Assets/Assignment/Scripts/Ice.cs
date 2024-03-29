using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ice : Monster
{
    Sprite sourceSpirit;
    SpriteRenderer sr;
    public Sprite attackSpirit;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        sourceSpirit = GetComponent<SpriteRenderer>().sprite;
        sr=GetComponent<SpriteRenderer>();
    }

    public override IEnumerator Attack(GameObject target)
    {
        sr.sprite = attackSpirit;
        target.SendMessage("Freeze");
        yield return new WaitForSeconds(1f);
        sr.sprite = sourceSpirit;

    }
    




    //Ice attack: stop at certain distance and freeze the player for one second

}
