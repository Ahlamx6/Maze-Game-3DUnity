using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgoal : MonoBehaviour
{
    public string Endgame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hala Walla");
            SceneManager.LoadScene(Endgame);
        }

    }
}
