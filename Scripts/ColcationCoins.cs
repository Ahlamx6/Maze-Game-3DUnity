using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColcationCoins : MonoBehaviour
{

private int  keys= 0;
public Text keyAmount;
    // Start is called before the first frame update
    void Start()
    {
        keys += 1;
            keyAmount.text = "Keys: " + keys;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Keys")
        {
            
            Destroy(collision.gameObject);
            //audioSource.Play();
            
            Debug.Log("Keys: " + keys);
        }

    }}
