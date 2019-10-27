using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Transform target;

    public float speed = 10f;
    public float damage = 5f;

    // Update is called once per frame
    void Update () {

        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
            
        }
	}

    void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.tag == "Enemy")
        {
            obj.SendMessage("Hurt", damage);
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
        else if (obj.tag == "Ground")
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
