using  System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour

{   public Animator animator;
    public GameObject fx;
    public GameObject scoreText;

  
   void OnTriggerEnter(Collider other)
   {   
      Debug.Log("Works");
       scoreSystem.score += 10;
       animator.SetTrigger("open");
       Destroy(gameObject,1f);
      GameObject clone =  Instantiate(fx,transform.position,Quaternion.identity) as GameObject;
        Destroy(clone,1f);
      
   }
  
 
}
