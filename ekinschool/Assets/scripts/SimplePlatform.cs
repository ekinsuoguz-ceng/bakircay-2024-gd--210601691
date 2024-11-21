using UnityEngine;

public class SimplePlatform : MonoBehaviour
{
    public Transform anchorPoint; // Platform �zerindeki sabit nokta

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit")) // Sadece 'Fruit' tagine sahip nesnelerle �al���r
        {
            // Nesneyi platforma d�zg�nce yerle�tir
            other.transform.position = anchorPoint.position;
            other.GetComponent<Rigidbody>().isKinematic = true; // Hareketi durdur
        }
    }
}
