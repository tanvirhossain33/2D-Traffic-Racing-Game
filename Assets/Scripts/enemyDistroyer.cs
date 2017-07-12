using UnityEngine;
using System.Collections;

public class enemyDistroyer : MonoBehaviour {


	//uiManager u = new uiManager();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D call)
    {
        if(call.gameObject.tag == "Enemy")
        {
            Destroy(call.gameObject);
			//u.score += 10;
        }
    }
}
