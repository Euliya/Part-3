using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    public Villager[] villager = new Villager[3];
    public TMP_Dropdown dropdown;
    

    private void Start()
    {
        Instance = this;
        DropdownHasChangedValue(0);
    }

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }

    public void DropdownHasChangedValue(int value)
    {
        SetSelectedVillager(villager[value]);    
    }

    public void SliderValueChanged(Single value)
    {
        SelectedVillager.transform.localScale = Vector3.one*value;
    }
    //private void Update()
    // {
    //   if(SelectedVillager != null)
    //   {
    //       currentSelection.text = SelectedVillager.GetType().ToString();
    //    }
    //}
}
