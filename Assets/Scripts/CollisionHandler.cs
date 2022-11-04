using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 5f;
    [SerializeField] ParticleSystem explosingVFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(this.name + "Collided with " + other.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{this.name} Trigger by {other.gameObject.name}");
        StartCrashSequence();
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void StartCrashSequence()
    {
        explosingVFX.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<PlayerControls>().enabled = false;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        Invoke("ReloadLevel", loadDelay);
    }
}
