using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;




public class Video : MonoBehaviour



{
    public VideoPlayer Videoa;
    public VideoClip[] videoClips;
    public GameObject ativar;
    
   
    
     

    void Awake()
    {
       // Videoa = GetComponent<VideoPlayer> ();
        
    }
    void Start()
    {
        StartCoroutine(Test ()); 
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(8);
        ativar.SetActive(true);
        Videoa.clip = videoClips [0];
        
    }
}
    
    // Start is called before the first frame update
    /*void Awake()
    {
        Videoa = GetComponent<VideoPlayer> ();
        
    }

    IEnumerator  Start()
    {
        coroutine = fds(2f);
        StartCoroutine(fds);
    }    
    IEnumerator fds()
    {
        yield return new WaitForSeconds(2);
        
        
        Videoa.clip = videoClips [0];

    }*/

    
    

    

