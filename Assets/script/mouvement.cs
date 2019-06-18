using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
	public float mouvSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempV = Input.GetAxis ("Vertical");
		float tempH = Input.GetAxis ("Horizontal");
		Debug.Log(transform.position);
		
		transform.position = new Vector3 (transform.position.x + tempH * Time.deltaTime * mouvSpeed, transform.position.y, transform.position.z + tempV * Time.deltaTime * mouvSpeed);
        

    }
}
