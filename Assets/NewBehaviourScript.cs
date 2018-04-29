using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //public makes it visible for the inspector
    public GameObject cube;
	
    // Use this for initialization
	void Start () {
       
	}

    void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(cube, new Vector3(), Quaternion.identity);
        }
	}

    private void FixedUpdate()
    {
        
    }
}
