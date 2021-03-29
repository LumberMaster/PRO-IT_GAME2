using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject[] weapons;
    public KeyCode next;
    public KeyCode prev;
    int index = 0; 

    private void Start() {
    }

    private void Update()
    {
        if (Input.GetKeyDown(next))
        {
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
           if(index >= weapons.Length)  index = 0;
           weapons[index].SetActive(true);
        }

        if(Input.GetKeyDown(prev)) {
            for (int i = 0; i < weapons.Length; i++)
            {

                if (weapons[i].activeInHierarchy == true)
                {
                  weapons[i].SetActive(false);
                  index = i;
                }
            }

           weapons[index].SetActive(false);
           index--;
           if(index <  0) index = weapons.Length - 1;
           weapons[index].SetActive(true);

        }
    }
}