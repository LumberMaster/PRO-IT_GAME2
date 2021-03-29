using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;
    public float speedFire;
    private float curTimeout;

    // Update is called once per frame
    void Update()
    {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
	{
		curTimeout += Time.deltaTime;
		if(curTimeout > speedFire)
		{
			curTimeout = 0;
			Instantiate(bullet, shotPoint.position, transform.rotation);
		}
	}
}