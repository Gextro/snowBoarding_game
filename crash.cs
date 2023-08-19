using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float loaddelay = 1f;
    [SerializeField] ParticleSystem crashmode;
    [SerializeField] AudioClip CrashSFX;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<player_controller>().DisableControls();
            crashmode.Play();
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            Invoke("Dead", loaddelay);
        }
    }
    void Dead()
    {
        SceneManager.LoadScene(0);
    }

}
