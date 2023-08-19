using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finisher : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finisheff;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finisheff.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
