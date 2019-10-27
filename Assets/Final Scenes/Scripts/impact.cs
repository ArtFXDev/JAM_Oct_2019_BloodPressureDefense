using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {

    public GameObject myPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision buuump)
    {
        ContactPoint[] pointss = buuump.contacts;

        for(int i=0; i<2; i++)
        {
            Instantiate(myPrefab, buuump.contacts[0].point, Quaternion.identity);

            if (buuump.contacts[0].point.x < 4)
            {
                gameObject.transform.position = new Vector3(11f, 8f, 5f);
            }
            break;
        }
        

    }
}
