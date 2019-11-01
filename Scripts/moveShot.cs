using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShot : MonoBehaviour
{
	// Start is called before the first frame update
	private Rigidbody rig;
    public float speed;

	void Awake()
	{
		rig = GetComponent<Rigidbody>();
    }
    void Start()
    {
		rig.velocity = transform.forward*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
