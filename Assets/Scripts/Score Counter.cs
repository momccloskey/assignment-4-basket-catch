using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int fishValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddToScore();
            Destroy(gameObject);
        }
    }

    private void AddToScore()
    {
        Debug.Log("caught fish worth: " + fishValue);
    }
}
