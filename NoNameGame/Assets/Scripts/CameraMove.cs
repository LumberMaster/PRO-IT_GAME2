using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;

 // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
             Camera.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y, -0.5f);
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Bullet"){
            Destroy(other.gameObject);
        }
    }
}
