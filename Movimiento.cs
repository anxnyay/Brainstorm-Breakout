using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad;
    public int numberofItems;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.Rotate(0,Input.GetAxis("Mouse X"),0);
    }

   private void OnTriggerEnter(Collider other)
   {
	   
		   GetComponent<AudioSource>().Play();
   }
   
    private void OnTriggerExit(Collider other)
   {
	   if(other.name == "Cube A")
		   Debug.Log("Hemos salido del cubo A");
   }
   
    private void OnTriggerStay(Collider other)
   {
	   if(other.tag == "Zona")
		   Debug.Log("Estamos en la zona");
           Destroy(other.gameObject);
           numberofItems = numberofItems  + 1;
        
        
   }

}

