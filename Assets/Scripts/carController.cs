using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

    public float carSpeed = 15f;
    Vector3 position;
    public uiManager ui;

    public audioManager am;
    
    

	// Use this for initialization
	void Start () {
        am.carSound.Play();


        position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        //for pc...
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;


        //for android
        float temp = Input.acceleration.x;
        position.x += temp * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;
       

        if (Time.timeScale == 0)
        {
            am.carSound.Pause();
        }
        else
        {
            am.carSound.UnPause();
        }



    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            //Destroy(coll.gameObject);
            Time.timeScale = 0;
            ui.gameOverActivated();
            am.carSound.Stop();
            
            
            
        }
            
    }







}
