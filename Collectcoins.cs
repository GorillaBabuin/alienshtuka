using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectcoins : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.Object part;
    [SerializeField] TextMeshProUGUI Text;
    Rigidbody rb;
    static int points = 0;
    ParticleSystem ps;
    UnityEngine.Object explosion;
    void Start()
    {
        explosion = Resources.Load("explosion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision arg)
    {
        if(arg.gameObject.tag == "Player"){
            Destroy(gameObject);
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = transform.position;
            
            points = points + 1;
            Text.text = points + "";
        }
    }
}
