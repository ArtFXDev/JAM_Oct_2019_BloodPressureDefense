using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 20f;
    float currentHealth;

    public GameObject healthPrefab;
    GameObject healthBar;

    public Transform currentWaypoint;
    public float moveSpeed = 1f;

	// Use this for initialization
	void Awake () {
        currentHealth = health;
        healthBar = Instantiate(healthPrefab, transform.position + new Vector3(0, 0, 0.25f), Quaternion.identity, transform);
	}

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (transform.position.Equals(currentWaypoint.position))
        {
            if (currentWaypoint.GetComponent<Waypoint>().nextWaypoint != null)
            {
                currentWaypoint = currentWaypoint.GetComponent<Waypoint>().nextWaypoint;
            }
        }
    }
	
    public void Hurt(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        Transform pivot = healthBar.transform.Find("HealthyPivot");
        Vector3 scale = pivot.localScale;
        scale.x = Mathf.Clamp(currentHealth / health, 0, 1);
        pivot.localScale = scale;
    }
}
