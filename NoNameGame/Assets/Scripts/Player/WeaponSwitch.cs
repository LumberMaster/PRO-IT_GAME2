using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject[] weapons;
    public KeyCode next;


    private void Update()
    {
        if (Input.GetKeyDown(next))
        {
            int index = 0;
            for (int i = 0; i < weapons.Length; i++)
            {

                if (weapons[i].activeInHierarchy == true)
                {
                  weapons[i].SetActive(false);
                  index = i;
                }
            }

           weapons[index].SetActive(false);
           index++;
           if(index >=  weapons.Length)  index = 0;
           weapons[index].SetActive(true);
        }
    }
}