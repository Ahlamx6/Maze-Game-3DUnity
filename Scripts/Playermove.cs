using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playermove : MonoBehaviour
{
    public int keys =0; 
    public float speed = 5.0f;

    public Text keyAmount;
    public Text youWin;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xmovement = Input.GetAxisRaw("Horizontal");
        float zmovement = Input.GetAxisRaw("Vertical");
        // transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
   
        Vector3 Velocity = Vector3.right * xmovement * speed * Time.deltaTime + Vector3.back * zmovement * speed * Time.deltaTime;

        transform.Translate(Velocity);

     if(keys==3)
        {
            Destroy(door);
        }
                       
    }

     
}

//AHLAM_HADDAD_AWESOME