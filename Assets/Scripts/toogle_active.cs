using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class toogle_active : MonoBehaviour
{
    public List<GameObject> list_GOs = new List<GameObject>();

    public String anim_trigger;

    public int anim_index;
    public Animator my_Animator;
    public bool toogle_me;

    void OnMouseDown()
    {   
        if(my_Animator != null)
        {
            my_Animator.SetTrigger(anim_trigger);       
        }

        if(list_GOs.Count > 0)
        {
            foreach(GameObject go in list_GOs)
            {
                go.SetActive(!toogle_me);
            }
        }
        
        toogle_me = !toogle_me;
    }

    
    

}
