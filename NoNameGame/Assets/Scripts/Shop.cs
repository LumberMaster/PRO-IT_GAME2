using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shop : MonoBehaviour
{
     public GameObject shop;

    private void OnTriggerEnter2D(Collider2D other){
          if(other.gameObject.tag == "Player"){
                    shop.SetActive(true);
          }
    }
    
    private void OnTriggerExit2D(Collider2D other){
          if(other.gameObject.tag == "Player"){
               shop.SetActive(false);
          }
    }
}
