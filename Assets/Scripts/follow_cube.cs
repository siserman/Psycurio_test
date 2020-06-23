 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.AI; 
 
 public class follow_cube : MonoBehaviour {
 
     public Transform cube;
     public float _speed = 3.5f;
     private NavMeshAgent capsule; 
 
 
     // Use this for initialization
     void Start () {
         
         capsule = GetComponent<NavMeshAgent> ();
 
     }
     
     // Update is called once per frame
     void Update () {
         
         capsule.speed = _speed;
         
         capsule.destination = cube.transform.position; 
         
     }
 }
