using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag.Equals("Bullet")){
            Score.scoreValue += 10;
            
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
