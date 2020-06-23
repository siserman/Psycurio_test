using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    public Vector3 orig_Postion;
    public Shelf myShelf;
    public int id;
    public string str_name;
    public string price;
    public bool clicked;
 
    void Start()
    {
        orig_Postion = transform.position;
    }

    public void ChangePosition(bool toogle_pos)
    {
        if(toogle_pos  && clicked)
        {
            MoveTo(transform.position,  myShelf._target.position, myShelf._anim_time);
        }
        else
        {
            transform.position = orig_Postion;
            //MoveTo(myShelf._target.position,  orig_Postion, myShelf._anim_time);
        }
    }

    void OnMouseDown()
    {   
        clicked = true;

        myShelf.ChooseProduct(id);
    }

    void MoveTo(Vector3 targetA, Vector3 targetB, float duration)
    {
        StartCoroutine(MoveCoro(targetA, targetB, duration));
    }

    
    IEnumerator MoveCoro(Vector3 source, Vector3 target, float time)
    {
        float start_time = 0f;
        while (start_time <= time)
        {
            start_time = start_time + Time.deltaTime;
            float range = Mathf.Clamp01(start_time / time);

            float curveRange = myShelf.animationCurve.Evaluate(range);
            transform.position = Vector3.LerpUnclamped(source, target, curveRange);
    
            yield return null;
        }
        
    }

}
