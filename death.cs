using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			other.transform.position = new Vector3 (-2.96f, 7.21f, 8.68f);
		}
	}
}
