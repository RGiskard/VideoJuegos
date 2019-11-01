using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAleatoria : MonoBehaviour
{
	// Start is called before the first frame update
	private Rigidbody rig;

	void Awake()
	{
		rig = GetComponent<Rigidbody>();
	}
	void Start()
    {
		Vector3 velocidadAngular=new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1)).normalized;
		//Normalizar vecotr

		rig.angularVelocity = velocidadAngular;
	}


}
