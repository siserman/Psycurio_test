using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Shelf : MonoBehaviour
{
    public Transform _target;
    private Vector3 _org_pos;
    public AnimationCurve animationCurve;
    public float _anim_time;

    public TextMeshProUGUI tm_speech;
    public List<Product> list_products = new List<Product>();

    public void ChooseProduct(int index)
    {
        foreach(Product prod in list_products)
        {
            prod.clicked = false;
            prod.ChangePosition(false);
        }

        list_products[index].clicked = true;
        list_products[index].ChangePosition(true);
        
        tm_speech.text = "You chose the "
                         + list_products[index].str_name +
                          " and it costs "
                           +list_products[index].price +" €";

    }

}
