using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{

    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Player"))
        {   
            StartCoroutine("Collected");
            GameManager.Instance.IncScore(1);  
            //Instantiate(effect);
            
        }
        
    }
    IEnumerator Collected()
    {
        audio.Play();
        Debug.Log("Playing Collection Now");
        yield return new WaitForSeconds(audio.clip.length);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
