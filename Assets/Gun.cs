using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;
    
    
    public void Fire()
    {
        GameObject spawnBulet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnBulet.GetComponent<Rigidbody>().velocity = speed * barrel.forward ;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnBulet, 2);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}