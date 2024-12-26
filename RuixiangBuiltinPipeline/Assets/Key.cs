using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{

    //public MeshRenderer meshRenderer;
    public GameObject door;
    public float upDistance = 3f;
    public float moveTime = 2f;
    public GameObject arrow;
    public AudioSource doorAudio;

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = false;
        // meshRenderer.enabled = false;

        if (other.CompareTag("Player"))
        {
            StartCoroutine(MoveDoorUp());
            Destroy(arrow);
        }
    }

    private IEnumerator MoveDoorUp()
    {
            if (doorAudio != null)
            {
                doorAudio.Play();
            }
        Vector3 startPos = door.transform.position;
        Vector3 endPos = startPos + Vector3.up * upDistance;

        float elapsed = 0f;
        while (elapsed < moveTime)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / moveTime;
            door.transform.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }
        door.transform.position = endPos;

        Destroy(gameObject);
    }
}
