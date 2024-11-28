using UnityEngine;

public class CerceauController : MonoBehaviour
{
    public CerveauBehaviour behaviour;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when another collider enters the trigger collider attached to the object where this script is attached
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Le joueur a passé à travers l'objet !");
            // Ajoutez ici le code que vous souhaitez exécuter lorsque le joueur passe à travers l'objet
        }
    }
}

public enum CerveauBehaviour
{
    good, bad
}