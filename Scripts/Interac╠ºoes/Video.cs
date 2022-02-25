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
    public GameObject TextoVitoria;
    
   
    
     

    void Awake()
    {
       // Videoa = GetComponent<VideoPlayer> ();
        
    }
    void Start()
    {
        StartCoroutine(Creditos ()); 
        StartCoroutine(TextoV ());
    }

    IEnumerator Creditos()
    {
        yield return new WaitForSeconds(10);
        ativar.SetActive(true);
        Videoa.clip = videoClips [0];
        TextoVitoria.SetActive(false);
        
    }
    IEnumerator TextoV()
    {
        yield return new WaitForSeconds(5);
        TextoVitoria.SetActive(true);

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

    
    

    

