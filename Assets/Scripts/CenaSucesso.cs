using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CenaSucesso : MonoBehaviour {

	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Player") {

            SceneManager.LoadScene("Sucesso");
		} 
	}
}
