using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other){
        if (other.collider.tag == "Player"){
            Destroy(this.gameObject);
        }
    }
}
