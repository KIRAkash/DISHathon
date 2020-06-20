using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audiomanager : MonoBehaviour
{
    public AudioSource a1;
    
    // Start is called before the first frame update
  public void playme(AudioClip clip)
    {
        a1.PlayOneShot(clip);
    }
}
