using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIdemo : MonoBehaviour
{
    public Color start;
    public Color end;
    float interpolation;
    public SpriteRenderer sr;
    public TMP_Dropdown dropdown;

    // Update is called once per frame
    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation / 60));
    }
    public void SliderValueChanged(Single value)
    {
        interpolation = value;
    }
    public void DropdownHasChangedValue(int value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
