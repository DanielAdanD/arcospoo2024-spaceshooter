using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLimit : MonoBehaviour
{
    private int count;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy reference = other.gameObject.GetComponent<Enemy>();
        if (reference != null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
