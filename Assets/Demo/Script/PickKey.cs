using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorcolliderhere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnTriggerStay()
	{
        if (Input.GetKey(KeyCode.E))
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
	}

}
